package servlets;

import entity.ejb.Customer;
import entity.ejb.Ingredient;
import entity.ejb.Order;
import entity.ejb.Orderspecification;
import entity.ejb.Product;
import entity.ejb.Recipe;
import facade.FacadeLocal;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Timestamp;
import java.util.List;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class CustomerServlet
 */
@WebServlet("/CustomerServlet")
public class CustomerServlet extends HttpServlet implements FacadeLocal {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public CustomerServlet() {
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
     * @see FacadeLocal#createCustomer(Customer)
     */
    public Customer createCustomer(Customer customer)  { 
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
     * @see FacadeLocal#findByPostalAddress(String)
     */
    public List<Customer> findByPostalAddress(String cPostalAddress)  { 
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
     * @see FacadeLocal#findAllCustomers()
     */
    public List<Customer> findAllCustomers()  { 
         // TODO Auto-generated method stub
			return null;
    }
	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		response.getWriter().append("Served at: ").append(request.getContextPath());
		PrintWriter out = response.getWriter();
		out.println("MainServlet-doGet");
		out.close();
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		doGet(request, response);
		
	}

}
