package facade;

import java.util.List;

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
		return customerEAO.findBycNumber(cNumber);

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
	public List<Customer> findAllCustomers() {
		return customerEAO.findAllCustomers();

	}

	@Override
	public List<Customer> findActive(Boolean isDelivered) {
		return customerEAO.findActive(isDelivered);

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
	
	
	

	@Override
	public Orderspecification findBypNumberONumber(String pNumber, String ONumber) {
		return orderspecificationEAO.findBypNumberONumber(pNumber, ONumber);
	}

	@Override
	public Orderspecification createOrderspecification(Orderspecification orderspecification) {
		return orderspecificationEAO.createOrderspecification(orderspecification);
	}

	@Override
	public Orderspecification updateOrderspecification(Orderspecification orderspecification) {
		return orderspecificationEAO.updateOrderspecification(orderspecification);
	}

	@Override
	public void deleteOrderspecification(String pNumber, String oNumber) {
		orderspecificationEAO.deleteOrderspecification(pNumber, oNumber);
	}

	
	
	
	@Override
	public Recipe findByiNumberPNumber(String iNumber, String pNumber) {
		return recipeEAO.findByiNumberPNumber(iNumber, pNumber);
	}

	@Override
	public Recipe createRecipe(Recipe recipe) {
		return recipeEAO.createRecipe(recipe);
	}

	@Override
	public Recipe updateRecipe(Recipe recipe) {
		return recipeEAO.updateRecipe(recipe);
	}

	@Override
	public void deleteRecipe(String iNumber, String pNumber) {
		recipeEAO.deleteRecipe(iNumber, pNumber);
	}
	
	public List <Order> findAllOrders(){
		return orderEAO.findAllOrders();
	}
	public List <Order> findCertainOrder (String oNumber){
		return orderEAO.findCertainOrder(oNumber);
		
	}
	

}
