package facade;

import javax.ejb.EJB;
import javax.ejb.Stateless;

import entity.ejb.Customer;
import entity.ejb.Ingredient;
import entityAccess.eao.CustomerEAOImplLocal;
import entityAccess.eao.IngredientEAOImplLocal;
import entityAccess.eao.OrderEAOImplLocal;
import entityAccess.eao.OrderspecificationEAOImplLocal;
import entityAccess.eao.ProductEAOImplLocal;
import entityAccess.eao.RecipeEAOImplLocal;

/**
 * Session Bean implementation class Facade
 */
@Stateless
public class Facade implements FacadeLocal {

	@EJB
	CustomerEAOImplLocal customerEAO;
	@EJB
	IngredientEAOImplLocal ingredientEAO;
	@EJB
	ProductEAOImplLocal productEAO;
	@EJB
	RecipeEAOImplLocal recipeEAO;
	@EJB
	OrderEAOImplLocal orderEAO;
	@EJB
	OrderspecificationEAOImplLocal orderspecificationEAO;

	/**
	 * Default constructor.
	 */
	public Facade() {
		// TODO Auto-generated constructor stub
	}

	@Override
	public Customer createCustomer(Customer customer) {
		return customerEAO.createCustomer(customer);
	}
	
	@Override
	public Customer findBycNumber(long cNumber) {
		return customerEAO.findBycNumber(cNumber) ;
		
	}

	@Override
	public Customer updateCustomer(Customer customer) {
		// TODO Auto-generated method stub
		return customerEAO.updateCustomer(customer);
	}

	@Override
	public void deleteCustomer(long cNumber) {
		// TODO Auto-generated method stub
		customerEAO.deleteCustomer(cNumber);
	}

	@Override
	public Ingredient findByiNumber(int iNumber) {
		// TODO Auto-generated method stub
		return ingredientEAO.findByiNumber(iNumber);
	}

	@Override
	public Ingredient createIngredient(Ingredient ingredient) {
		// TODO Auto-generated method stub
		return ingredientEAO.createIngredient(ingredient);
	}

	@Override
	public Ingredient updateIngredient(Ingredient ingredient) {
		// TODO Auto-generated method stub
		return ingredientEAO.updateIngredient(ingredient);
	}

	@Override
	public void deleteIngredient(int iNumber) {
		// TODO Auto-generated method stub
		ingredientEAO.deleteIngredient(iNumber);
	}
}
