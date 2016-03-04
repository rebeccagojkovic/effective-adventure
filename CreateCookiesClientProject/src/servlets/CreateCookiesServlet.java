package servlets;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Timestamp;
import java.util.List;

import javax.ejb.EJB;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import org.jboss.resteasy.util.FindAnnotation;

import entity.ejb.*;
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
	protected void service(HttpServletRequest request,
			HttpServletResponse response) throws ServletException, IOException {
		PrintWriter out = response.getWriter();
		out.println("<!DOCTYPE html><html><head>");
		out.println("<title>CreateCookies</title>");
		out.println("<meta charset=\"ISO-8859-1\">");
		out.println("</head><body>");
		out.println("<h3>CreateCookies</h3>" + "<br>");

		// * Customer *//

		out.println("** Customer **" + "<br>");

		List<Customer> allcustomers = facade.findAllCustomers();
		for (Customer cu1 : allcustomers) {
			out.println("<h4>Hittade: " + cu1.getClass().getSimpleName());
			out.println(" Id: " + cu1.getcNumber());
			out.println(" - " + cu1.getcName());
			out.println(" - " + cu1.getcAddress() + "</h4>");

		}
		
//		Customer customeremail = facade.getCustomerByEmail("ake");
//		out.println("<h4>Hittade: " + customeremail.getcNumber());
		

		// * Ingredient *//

		out.println("** Ingredient **" + "<br>");
		Ingredient i = new Ingredient();
		Ingredient i1 = new Ingredient();
		i.setiNumber("3");
		i.setiName("Choklad");
		i.setiQuantityInStock(10000);
		i1.setiNumber("7");
		i1.setiName("Sylt");
		i1.setiQuantityInStock(10000);
		// facade.createIngredient(i);
		// facade.createIngredient(i1);

		List<Ingredient> allingredients = facade.findAllIngredients();
		for (Ingredient in1 : allingredients) {
			out.println("<h4>Hittade: " + in1.getClass().getSimpleName());
			out.println(" Id: " + in1.getiNumber());
			out.println(" - " + in1.getiName());
			out.println(" - " + in1.getiQuantityInStock() + "</h4>");

		}

		Ingredient i11 = facade.findByiNumber("3");
		if (i11 != null)

		{
			out.println("<h4>Hittade: " + i11.getiName() + "</h4>");
			out.println("");
		}

		List<Ingredient> ingredientsearch = facade.findByName("choklad");
		for (Ingredient i111 : ingredientsearch) {
			out.println("<h4>Hittade: " + i111.getClass().getSimpleName());
			out.println(" Id: " + i111.getiNumber());
			out.println(" - " + i111.getiName());
			out.println(" - " + i111.getiQuantityInStock() + "</h4>");

		}

		// * Order *//

		Order o1 = new Order();
		o1.setCustomer(facade.findBycNumber("1"));
		o1.setoNumber("2");
//		o1.setExpectedDeliveryDate(o1.getExpectedDeliveryDate());
		
		

		facade.updateOrder(o1);

		out.println("** Order **" + "<br>");

		List<Order> ordersearch = facade.findAllOrders();
		for (Order or1 : ordersearch) {
			out.println("<h4>Hittade: " + or1.getClass().getSimpleName());
			out.println(" Id: " + or1.getoNumber());
			out.println(" - " + or1.getoNumber() + "</h4>");

		}

		List<Order> orderisdelivered = facade.isDelivered(true);
		for (Order or2 : orderisdelivered) {
			out.println("<h4>Hittade: " + or2.getClass().getSimpleName());
			out.println(" Id: " + or2.getoNumber() + "</h4>");
		}
		
		List<Order> ordercertain = facade.findCertainOrder("2");
		
		for (Order or3 : ordercertain){
			out.println("<h4>Hittade: " + or3.getClass().getSimpleName());
			out.println(" Id: " + or3.getoNumber() + "</h4>");
		}

		// * Orderspecification *//

		out.println("** Orderspecification **" + "<br>");

		// * Product *//

		out.println("** Product **" + "<br>");

		// Product p = new Product();
		// p.setpNumber("1");
		// p.setpName("Socker");
		// p.setpTime(null);
		// facade.createProduct(p);
		//
		// Recipe r = new Recipe();
		// RecipeId rid = new RecipeId();
		// rid.setiNumber("3");
		// rid.setpNumber("1");
		// facade.createRecipe(r);

		List<Product> productsearch = facade.findAllProducts();
		for (Product pr1 : productsearch) {
			out.println("<h4>Hittade: " + pr1.getClass().getSimpleName());
			out.println(" Id: " + pr1.getpNumber());
			out.println(" - " + pr1.getpName());
			out.println(" - " + pr1.getpTime());
			out.println(" - " + pr1.getPrice() + "</h4>");

		}

		List<Product> productname = facade.findBypName("kokostoppar");
		for (Product pr1 : productname) {
			out.println("<h4>Hittade: " + pr1.getClass().getSimpleName());
			out.println(" Id: " + pr1.getpNumber());
			out.println(" - " + pr1.getpName());
			out.println(" - " + pr1.getpTime());
			out.println(" - " + pr1.getPrice() + "</h4>");

		}

		List<Product> producttime = facade.InfoTimeStamp(Timestamp
				.valueOf("1900-01-01 11:20:24.000"));
		for (Product pr2 : producttime) {
			out.println("<h4>Hittade: " + pr2.getClass().getSimpleName());
			out.println(" Id: " + pr2.getpNumber() + "</h4>");

		}

		// * Recipe *//

		out.println("** Recipe **" + "<br>");

		out.println("</body></html>");

	}
}
