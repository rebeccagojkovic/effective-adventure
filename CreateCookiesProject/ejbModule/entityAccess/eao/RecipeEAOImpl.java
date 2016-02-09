package entityAccess.eao;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

import entity.ejb.Orderspecification;
import entity.ejb.Recipe;
import entity.ejb.RecipeId;

/**
 * Session Bean implementation class RecipeEAOImpl
 */
@Stateless
public class RecipeEAOImpl implements RecipeEAOImplLocal {

	@PersistenceContext(unitName = "LabEJBSQL")
	private EntityManager em;

	/**
	 * Default constructor.
	 */
	public RecipeEAOImpl() {
		// TODO Auto-generated constructor stub
	}

	public Recipe findByiNumberPNumber(String iNumber, String pNumber) {
		RecipeId iNumberPNumber= new RecipeId(iNumber,pNumber);
		return em.find(Recipe.class, iNumberPNumber);

	}

	public Recipe createRecipe(Recipe recipe) {
		em.persist(recipe);
		return recipe;
	}

	public Recipe updateRecipe(Recipe recipe) {
		em.merge(recipe);
		return recipe;
	}

	public void deleteRecipe(String iNumber, String pNumber) {
		Recipe r = this.findByiNumberPNumber(iNumber, pNumber);
		if (r != null) {
			em.remove(r);
		}
	}

}
