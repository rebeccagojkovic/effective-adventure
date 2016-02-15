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

	public Customer findBycNumber(long cNumber);

	public Customer updateCustomer(Customer customer);

	public void deleteCustomer(long cNumber);
	
	public List<Customer> findActive(Boolean isDelivered);

	public List<Customer> findAllCustomers();
	
	public List<Order> findAllOrders();
	public List<Order> findCertainOrder(String oNumber);
	

	public Ingredient findByiNumber(int iNumber);

	public Ingredient createIngredient(Ingredient ingredient);

	public Ingredient updateIngredient(Ingredient ingredient);

	public void deleteIngredient(int iNumber);
	
	

	public Order findByoNumber(long oNumber);

	public Order createOrder(Order order);

	public Order updateOrder(Order order);

	public void deleteOrder(long oNumber);
	
	

	public Product findBypNumber(int pNumber);

	public Product createProduct(Product product);

	public Product updateProduct(Product product);

	public void deleteProduct(int pNumber);
	

	public Orderspecification findBypNumberONumber(String pNumber,
			String ONumber);

	public Orderspecification createOrderspecification(
			Orderspecification orderspecification);

	public Orderspecification updateOrderspecification(
			Orderspecification orderspecification);

	public void deleteOrderspecification(String pNumber, String oNumber);
	
	

	public Recipe findByiNumberPNumber(String iNumber, String pNumber);

	public Recipe createRecipe(Recipe recipe);

	public Recipe updateRecipe(Recipe recipe);

	public void deleteRecipe(String iNumber, String pNumber);

	

}
