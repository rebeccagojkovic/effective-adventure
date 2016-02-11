package facade;

import javax.ejb.EJB;
import javax.ejb.Stateless;

import entity.ejb.Customer;
import entity.ejb.Ingredient;
import entity.ejb.Order;
import entity.ejb.Orderspecification;
import entity.ejb.Product;
import entity.ejb.Recipe;
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
		return customerEAO.updateCustomer(customer);
	}

	@Override
	public void deleteCustomer(long cNumber) {
		customerEAO.deleteCustomer(cNumber);
	}

	@Override
	public Ingredient findByiNumber(int iNumber) {
		return ingredientEAO.findByiNumber(iNumber);
	}

	@Override
	public Ingredient createIngredient(Ingredient ingredient) {
		return ingredientEAO.createIngredient(ingredient);
	}

	@Override
	public Ingredient updateIngredient(Ingredient ingredient) {
		return ingredientEAO.updateIngredient(ingredient);
	}

	@Override
	public void deleteIngredient(int iNumber) {
		ingredientEAO.deleteIngredient(iNumber);
	}
	@Override
	public Order findByoNumber(long oNumber) {
		return orderEAO.findByoNumber(oNumber);
	}

	@Override
	public Order createOrder(Order order) {
		return orderEAO.createOrder(order);
	}

	@Override
	public Order updateOrder(Order order) {
		return orderEAO.updateOrder(order);
	}

	@Override
	public void deleteOrder(long oNumber) {
		orderEAO.deleteOrder(oNumber);
	}
	
	@Override
	public Product findBypNumber(int pNumber) {
		return productEAO.findBypNumber(pNumber);
	}

	@Override
	public Product createProduct(Product product) {
		return productEAO.createProduct(product);
	}

	@Override
	public Product updateProduct(Product product) {
		return productEAO.updateProduct(product);
	}

	@Override
	public void deleteProduct(int pNumber) {
		productEAO.deleteProduct(pNumber);
	}

	
}
