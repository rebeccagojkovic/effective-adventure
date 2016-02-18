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

import entity.ejb.Customer;
import entity.ejb.Ingredient;
import entity.ejb.Orderspecification;
import entity.ejb.Product;
import entity.ejb.Recipe;
import entity.ejb.RecipeId;
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
		Ingredient i1 = new Ingredient();
		i.setiNumber("3");
		i.setiName("Choklad");
		i.setiQuantityInStock(10000);
		i1.setiNumber("7");
		i1.setiName("Sylt");
		i1.setiQuantityInStock(10000);
		// facade.createIngredient(i);
		// facade.createIngredient(i1);
		
		//* Ingredient *//

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
		out.println("</body></html>");
		
		List<Ingredient> ingredientsearch = facade.findByName("choklad");
		for (Ingredient i111 : ingredientsearch) {
			out.println("<h4>Hittade: " + i111.getClass().getSimpleName());
			out.println(" Id: " + i111.getiNumber());
			out.println(" - " + i111.getiName());
			out.println(" - " + i111.getiQuantityInStock() + "</h4>");

		}
		
		//* Product *//
		
		List<Product> productsearch = facade.findAllProducts();
		for (Product pr1 : productsearch) {
			out.println("<h4>Hittade: " + pr1.getClass().getSimpleName());
			out.println(" Id: " + pr1.getpNumber());
			out.println(" - " + pr1.getpName());
			out.println(" - " + pr1.getpTime());
			out.println(" - " + pr1.getPrice()+ "</h4>");

		}
		
		List<Product> productname = facade.findBypName("kokostoppar");
		for (Product pr1 : productname) {
			out.println("<h4>Hittade: " + pr1.getClass().getSimpleName());
			out.println(" Id: " + pr1.getpNumber());
			out.println(" - " + pr1.getpName());
			out.println(" - " + pr1.getpTime());
			out.println(" - " + pr1.getPrice()+ "</h4>");

		}
		
		List<Product> producttime = facade.InfoTimeStamp(Timestamp.valueOf("1900-01-01 11:20:24.000"));
		for (Product pr2 : producttime){
			out.println("<h4>Hittade: " + pr2.getClass().getSimpleName());
			out.println(" Id: " + pr2.getpNumber()+ "</h4>");
			
		}
		
		//*  Order *//
		
/*		List<Product> ordersearch = facade.findAllOrders();
		for (Product or1 : ordersearch) {
			out.println("<h4>Hittade: " + or1.getClass().getSimpleName());
			out.println(" Id: " + or1.getoNumber());
			out.println(" - " + or1.getoName()+ "</h4>");

		}*/
		
		

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

	}
}
