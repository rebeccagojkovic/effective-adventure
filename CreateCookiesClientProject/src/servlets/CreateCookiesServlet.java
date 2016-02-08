package servlets;

import java.io.IOException;
import java.io.PrintWriter;

import javax.ejb.EJB;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import entity.ejb.Customer;
import facade.FacadeLocal;


/**
 * Servlet implementation class CreateCookiesServlet
 */
@WebServlet("/CreateCookiesServlet")
public class CreateCookiesServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	
	@EJB
	FacadeLocal facade;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public CreateCookiesServlet() {
		super();
		// TODO Auto-generated constructor stub
	}

	/**
	 * @see HttpServlet#service(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void service(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		// TODO Auto-generated method stub
		PrintWriter out = response.getWriter();
		out.println("<!DOCTYPE html><html><head>");
		out.println("<title>CreateCookies</title>");
		out.println("<meta charset=\"ISO-8859-1\">");
		out.println("</head><body>");
		out.println("<h3>Customer</h3>" + "<br>");
		out.println("** Create Customer **" + "<br>");
//		Customer c1 = new Customer();
//		c1.setcNumber(1);
//		c1.setcName("Mormors bageri");
//		c1.setcAddress("Lund");
//		facade.createCustomer(c1);
		out.println("</body></html>");
	}

}
