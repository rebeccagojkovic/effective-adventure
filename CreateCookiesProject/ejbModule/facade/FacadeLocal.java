package facade;

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

	

	
}
