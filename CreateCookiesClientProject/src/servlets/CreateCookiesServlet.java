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
import entity.ejb.Ingredient;
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
	
	}

	/**
	 * @see HttpServlet#service(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void service(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		PrintWriter out = response.getWriter();
		out.println("<!DOCTYPE html><html><head>");
		out.println("<title>CreateCookies</title>");
		out.println("<meta charset=\"ISO-8859-1\">");
		out.println("</head><body>");
		out.println("<h3>Customer</h3>" + "<br>");
		out.println("** Create Ingredient **" + "<br>");
		Ingredient i = new Ingredient();
		i.setiNumber("5");
		i.setiName("Smör");
		i.setiQuantityInStock(10000);
		facade.createIngredient(i);
		Ingredient i1 = new Ingredient();
		i1.setiNumber("6");
		i1.setiName("Choklad");
		i1.setiQuantityInStock(10000);
		facade.createIngredient(i1);
		out.println("</body></html>");
	}

}
