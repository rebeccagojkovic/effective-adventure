package facade;

import java.util.List;

import javax.ejb.Local;

import entity.ejb.Customer;
import entity.ejb.Ingredient;
import entity.ejb.Order;
import entity.ejb.Orderspecification;
import entity.ejb.Product;
import entity.ejb.Recipe;

@Local
public interface FacadeLocal {

	public Customer createCustomer(Customer customer);

	public Customer findBycNumber(String cNumber);

	public Customer updateCustomer(Customer customer);

	public void deleteCustomer(String cNumber);

	public List<Customer> findAllCustomers();

	public List<Customer> findByAddress(String cAddress);

	public List<Customer> findByCountry(String cCountry);

	public List<Customer> findByPostalAddress(String cPostalAddress);

	public List<Customer> findBycName(String cName);

	public List<Order> findAllOrders();

	// public List<Order> findCertainOrder(String customer);
	// public List<Order> isDelivered();

	// public List<Product>findAllProducts();
	// public List<Product>InfoTimeStamp(String pName);

	// public List<Recipe>findAllRecipes();
	// public List<Recipe>countRecipes();

	public Ingredient findByiNumber(String iNumber);

	public List<Ingredient> findByName(String iName);

	public List<Ingredient> findAllIngredients();

	public Ingredient createIngredient(Ingredient ingredient);

	public Ingredient updateIngredient(Ingredient ingredient);

	public void deleteIngredient(String iNumber);

	public Order findByoNumber(String oNumber);

	public Order createOrder(Order order);

	public Order updateOrder(Order order);

	public void deleteOrder(String oNumber);

	public Product findBypNumber(String pNumber);

	public Product createProduct(Product product);

	public Product updateProduct(Product product);

	public void deleteProduct(String pNumber);

	public Orderspecification findBypNumberONumber(String pNumber, String ONumber);

	public Orderspecification createOrderspecification(Orderspecification orderspecification);

	public Orderspecification updateOrderspecification(Orderspecification orderspecification);

	public void deleteOrderspecification(String pNumber, String oNumber);

	public Recipe findByiNumberPNumber(String iNumber, String pNumber);

	public Recipe createRecipe(Recipe recipe);

	public Recipe updateRecipe(Recipe recipe);

	public void deleteRecipe(String iNumber, String pNumber);

}
