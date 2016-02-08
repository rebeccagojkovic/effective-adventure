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
	@Override
	public Order findByoNumber(long oNumber) {
		// TODO Auto-generated method stub
		return orderEAO.findByoNumber(oNumber);
	}

	@Override
	public Order createOrder(Order order) {
		// TODO Auto-generated method stub
		return orderEAO.createOrder(order);
	}

	@Override
	public Order updateOrder(Order order) {
		// TODO Auto-generated method stub
		return orderEAO.updateOrder(order);
	}

	@Override
	public void deleteOrder(long oNumber) {
		// TODO Auto-generated method stub
		orderEAO.deleteOrder(oNumber);
	}
	
	@Override
	public Product findBypNumber(int pNumber) {
		// TODO Auto-generated method stub
		return productEAO.findBypNumber(pNumber);
	}

	@Override
	public Product createProduct(Product product) {
		// TODO Auto-generated method stub
		return productEAO.createProduct(product);
	}

	@Override
	public Product updateProduct(Product product) {
		// TODO Auto-generated method stub
		return productEAO.updateProduct(product);
	}

	@Override
	public void deleteProduct(int pNumber) {
		// TODO Auto-generated method stub
		productEAO.deleteProduct(pNumber);
	}

	
}
