package entityAccess.eao;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.TypedQuery;
import java.util.List;

import entity.ejb.Ingredient;

/**
 * Session Bean implementation class IngredientEAOImpl
 */
@Stateless
public class IngredientEAOImpl implements IngredientEAOImplLocal {

	@PersistenceContext(unitName = "LabEJBSQL")
	private EntityManager em;

	/**
	 * Default constructor.
	 */
	public IngredientEAOImpl() {
	}

	@Override
	public Ingredient findByiNumber(String iNumber) {
		return em.find(Ingredient.class, iNumber);

	}

	@Override
	public Ingredient createIngredient(Ingredient ingredient) {
		em.persist(ingredient);
		return ingredient;
	}

	@Override
	public Ingredient updateIngredient(Ingredient ingredient) {
		em.merge(ingredient);
		return ingredient;
	}

	@Override
	public void deleteIngredient(String iNumber) {
		Ingredient i = this.findByiNumber(iNumber);
		if (i != null) {
			em.remove(i);
		}
	}

	@Override
	public List<Ingredient> findAllIngredients() {
		TypedQuery<Ingredient> query = em.createNamedQuery("Ingredient.findAllIngredients", Ingredient.class);
		List<Ingredient> results = query.getResultList();
		return results;
	}
	
	
	@Override
	public List<Ingredient> findByiName(String iName) {
		TypedQuery<Ingredient> query = em.createNamedQuery("Ingredient.findByiName", Ingredient.class);
		query.setParameter("iName", iName);
		List<Ingredient> results = query.getResultList();
		return results;
	}
	@Override
	public List<Ingredient> findByiQuantityInStock(double iQuantityInStock) {
		TypedQuery<Ingredient> query = em.createNamedQuery("Ingredient.findByiQuantityInStock", Ingredient.class);
		query.setParameter("iQuantityInStock", iQuantityInStock);
		List<Ingredient> results = query.getResultList();
		return results;
	}
}
