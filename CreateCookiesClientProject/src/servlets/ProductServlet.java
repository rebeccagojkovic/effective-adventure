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
 * Servlet implementation class ProductServlet
 */
@WebServlet("/ProductServlet")
public class ProductServlet extends HttpServlet implements FacadeLocal {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public ProductServlet() {
        super();
        // TODO Auto-generated constructor stub
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
     * @see FacadeLocal#findAllProducts()
     */
    public List<Product> findAllProducts()  { 
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
     * @see FacadeLocal#updateProduct(Product)
     */
    public Product updateProduct(Product product)  { 
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
