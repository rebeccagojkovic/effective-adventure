package facade;

import java.sql.Timestamp;
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
	}

	// * Customer *//

	@Override
	public Customer createCustomer(Customer customer) {
		return customerEAO.createCustomer(customer);
	}

	@Override
	public Customer findBycNumber(String cNumber) {
		return customerEAO.findBycNumber(cNumber);

	}

	@Override
	public Customer updateCustomer(Customer customer) {
		return customerEAO.updateCustomer(customer);
	}

	@Override
	public void deleteCustomer(String cNumber) {
		customerEAO.deleteCustomer(cNumber);
	}

	@Override
	public List<Customer> findAllCustomers() {
		return customerEAO.findAllCustomers();

	}

	@Override
	public List<Customer> findByAddress(String cAddress) {
		return customerEAO.findByAddress(cAddress);
	}

	@Override
	public List<Customer> findByCountry(String cCountry) {
		return customerEAO.findByCountry(cCountry);
	}

	@Override
	public List<Customer> findByPostalAddress(String cPostalAddress) {
		return customerEAO.findByPostalAddress(cPostalAddress);
	}

	@Override
	public List<Customer> findBycName(String cName) {
		return customerEAO.findBycName(cName);
	}
	
	@Override
	public List<Customer> findBycEmail(String cEmail) {
		return customerEAO.findBycEmail(cEmail);
	}

	// * Ingredient *//

	@Override
	public Ingredient findByiNumber(String iNumber) {
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
	public void deleteIngredient(String iNumber) {
		ingredientEAO.deleteIngredient(iNumber);
	}

	@Override
	public List<Ingredient> findByName(String iName) {
		return ingredientEAO.findByName(iName);
	}

	@Override
	public List<Ingredient> findAllIngredients() {
		return ingredientEAO.findAllIngredients();
	}

	// * Order *//

	@Override
	public Order findByoNumber(String oNumber) {
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
	public void deleteOrder(String oNumber) {
		orderEAO.deleteOrder(oNumber);
	}

	@Override
	public List<Order> findAllOrders() {
		return orderEAO.findAllOrders();
	}

	@Override
	public List<Order> isDelivered(boolean isDelivered) {
		return orderEAO.isDelivered(isDelivered);
	}

	// @Override
	// public List <Order> isDelivered(boolean isDelivered) {
	// for(Order o : isDelivered){
	// if(Order o = false){
	// return o.getoNumber;
	// else return null;
	// }}}

	@Override
	public List<Order> findCertainOrder(String customer) {
		return orderEAO.findCertainOrder(customer);
	}

	// * Product *//

	@Override
	public List<Product> findAllProducts() {
		return productEAO.findAllProducts();
	}

	@Override
	public List<Product> InfoTimeStamp(Timestamp pTime) {
		return productEAO.InfoTimeStamp(pTime);
	}

	@Override
	public Product findBypNumber(String pNumber) {
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
	public void deleteProduct(String pNumber) {
		productEAO.deleteProduct(pNumber);
	}

	@Override
	public List<Product> findBypName(String pName) {
		return productEAO.findBypName(pName);
	}

	// * Order Specification *//

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

	// * Recipe *//

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

	@Override
	public List<Recipe> findAllRecipes() {
		return recipeEAO.findAllRecipes();
	}

	@Override
	public List<Recipe> countRecipes() {
		return recipeEAO.countRecipes();
	}
}