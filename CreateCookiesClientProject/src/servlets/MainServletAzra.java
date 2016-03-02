package servlets;

import entity.ejb.Customer;
import entity.ejb.Ingredient;
import entity.ejb.Order;
import entity.ejb.Orderspecification;
import entity.ejb.Product;
import entity.ejb.Recipe;
import facade.FacadeLocal;
import java.io.IOException;
import java.sql.Timestamp;
import java.util.List;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class MainServletAzra
 */
@WebServlet("/MainServletAzra")
public class MainServletAzra extends HttpServlet implements FacadeLocal {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public MainServletAzra() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
     * @see FacadeLocal#findBycEmail(String)
     */
    public List<Customer> findBycEmail(String cEmail)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#deleteCustomer(String)
     */
    public void deleteCustomer(String cNumber)  { 
         // TODO Auto-generated method stub
    }

	/**
     * @see FacadeLocal#findCertainOrder(String)
     */
    public List<Order> findCertainOrder(String customer)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#isDelivered(boolean)
     */
    public List<Order> isDelivered(boolean isDelivered)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findByiNumberPNumber(String, String)
     */
    public Recipe findByiNumberPNumber(String iNumber, String pNumber)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#createRecipe(Recipe)
     */
    public Recipe createRecipe(Recipe recipe)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#updateCustomer(Customer)
     */
    public Customer updateCustomer(Customer customer)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findBycName(String)
     */
    public List<Customer> findBycName(String cName)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findAllOrders()
     */
    public List<Order> findAllOrders()  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findByoNumber(String)
     */
    public Order findByoNumber(String oNumber)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#createCustomer(Customer)
     */
    public Customer createCustomer(Customer customer)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#createOrder(Order)
     */
    public Order createOrder(Order order)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findByAddress(String)
     */
    public List<Customer> findByAddress(String cAddress)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#createOrderspecification(Orderspecification)
     */
    public Orderspecification createOrderspecification(Orderspecification orderspecification)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findAllIngredients()
     */
    public List<Ingredient> findAllIngredients()  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#updateOrderspecification(Orderspecification)
     */
    public Orderspecification updateOrderspecification(Orderspecification orderspecification)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#InfoTimeStamp(Timestamp)
     */
    public List<Product> InfoTimeStamp(Timestamp pTime)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findBypName(String)
     */
    public List<Product> findBypName(String pName)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#updateOrder(Order)
     */
    public Order updateOrder(Order order)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findBypNumber(String)
     */
    public Product findBypNumber(String pNumber)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#createProduct(Product)
     */
    public Product createProduct(Product product)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findByPostalAddress(String)
     */
    public List<Customer> findByPostalAddress(String cPostalAddress)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findAllProducts()
     */
    public List<Product> findAllProducts()  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findBypNumberONumber(String, String)
     */
    public Orderspecification findBypNumberONumber(String pNumber, String ONumber)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findAllRecipes()
     */
    public List<Recipe> findAllRecipes()  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findByCountry(String)
     */
    public List<Customer> findByCountry(String cCountry)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findBycNumber(String)
     */
    public Customer findBycNumber(String cNumber)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#deleteOrderspecification(String, String)
     */
    public void deleteOrderspecification(String pNumber, String oNumber)  { 
         // TODO Auto-generated method stub
    }

	/**
     * @see FacadeLocal#createIngredient(Ingredient)
     */
    public Ingredient createIngredient(Ingredient ingredient)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#deleteProduct(String)
     */
    public void deleteProduct(String pNumber)  { 
         // TODO Auto-generated method stub
    }

	/**
     * @see FacadeLocal#deleteRecipe(String, String)
     */
    public void deleteRecipe(String iNumber, String pNumber)  { 
         // TODO Auto-generated method stub
    }

	/**
     * @see FacadeLocal#deleteOrder(String)
     */
    public void deleteOrder(String oNumber)  { 
         // TODO Auto-generated method stub
    }

	/**
     * @see FacadeLocal#findByName(String)
     */
    public List<Ingredient> findByName(String iName)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#findAllCustomers()
     */
    public List<Customer> findAllCustomers()  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#deleteIngredient(String)
     */
    public void deleteIngredient(String iNumber)  { 
         // TODO Auto-generated method stub
    }

	/**
     * @see FacadeLocal#findByiNumber(String)
     */
    public Ingredient findByiNumber(String iNumber)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#updateIngredient(Ingredient)
     */
    public Ingredient updateIngredient(Ingredient ingredient)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#countRecipes()
     */
    public List<Recipe> countRecipes()  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#updateProduct(Product)
     */
    public Product updateProduct(Product product)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
     * @see FacadeLocal#updateRecipe(Recipe)
     */
    public Recipe updateRecipe(Recipe recipe)  { 
         // TODO Auto-generated method stub
			return null;
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.getWriter().append("Served at: ").append(request.getContextPath());
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
	}

}
