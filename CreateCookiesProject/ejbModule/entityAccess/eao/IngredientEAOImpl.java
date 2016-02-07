package entityAccess.eao;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

import entity.ejb.Ingredient;

/**
 * Session Bean implementation class IngredientEAOImpl
 */
@Stateless
public  class IngredientEAOImpl implements IngredientEAOImplLocal {
	
	@PersistenceContext(unitName = "LabEJBSQL")
	private EntityManager em;
    /**
     * Default constructor. 
     */
    public IngredientEAOImpl() {
        // TODO Auto-generated constructor stub
    }
    public Ingredient findByiNumber(int iNumber) {
		return em.find(Ingredient.class, iNumber);

	}

	public Ingredient createIngredient(Ingredient ingredient) {
		em.persist(ingredient);
		return ingredient;
	}

	public Ingredient updateIngredient(Ingredient ingredient) {
		em.merge(ingredient);
		return ingredient;
	}

	public void deleteIngredient(int iNumber) {
		Ingredient i = this.findByiNumber(iNumber);
		if (i != null) {
			em.remove(i);
		}
	}
	
}


