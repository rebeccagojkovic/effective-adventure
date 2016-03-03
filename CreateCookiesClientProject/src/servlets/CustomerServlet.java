package servlets;

import java.io.IOException;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.PrintWriter;
import entity.ejb.Customer;

/**
 * Servlet implementation class CustomerServlet
 */
@WebServlet("/CustomerServlet")
public class CustomerServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
    /**
     * @see HttpServlet#HttpServlet()
     */
    public CustomerServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//response.getWriter().append("Served at: ").append(request.getContextPath());
	    PrintWriter out= response.getWriter();
	    out.println("CustomerServlet-doGet");
	    out.close();
	
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		//doGet(request, response);
		String url = null;
		//Get hidden field
		String operation = request.getParameter("operation");
		if (operation.equals("ShowCustomer")) {
		System.out.println("MainServlet-showCustomer");
		String name = request.getParameter("companyName");
		String email = request.getParameter("email");
		String country = request.getParameter("country");
		String postalAddress = request.getParameter("postalAddress");
		String address = request.getParameter("address");
		Customer c= new Customer("", name,email,country,postalAddress,address);
		request.setAttribute("customer", c);
		url = "/ShowCustomer.jsp";
		} else if (operation.equals("SearchCustomer")) {
		System.out.println("CustomerServlet-SearchCustomer");
		   url = "/SearchCustomer.jsp";
		} else {
		   url ="/SearchCustomer.jsp";
		}
		System.out.println(url);
		RequestDispatcher dispatcher = getServletContext().getRequestDispatcher(url);
		dispatcher.forward(request, response);
	}

}
