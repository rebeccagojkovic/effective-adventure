package servlets;

import java.io.IOException;
import java.util.List;

import javax.ejb.EJB;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import entity.ejb.Ingredient;
import facade.FacadeLocal;

/**
 * Servlet implementation class IngredientServlet
 */
@WebServlet("/IngredientServlet")
public class IngredientServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	@EJB
	FacadeLocal facade;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public IngredientServlet() {
		super();
		// TODO Auto-generated constructor stub
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		request.setCharacterEncoding("UTF-8");

		String url = null;
		String operation = request.getParameter("operation");
		if (operation.equals("showingredient")) {
			System.out.println("MainServlet-showingredient");

			String iNumber = request.getParameter("iNumber");
			String iName = request.getParameter("iName");
			String iQuantityInStock = request.getParameter("iQuantityInStock");
//			double d = Double.parseDouble(iQuantityInStock);

			String searchIngredient = request.getParameter("searchIngredient");

			if (request.getParameter("radioIngredientSearch") != null) {
				if (request.getParameter("radioIngredientSearch").equals("iNumber")) {
					request.setAttribute("searchIngredient", iNumber);

					Ingredient number = facade.findByiNumber(searchIngredient);

					request.setAttribute("ingredient", number);

					System.out.println(iNumber);
					url = "/ShowIngredient.jsp";
				}
				if (request.getParameter("radioIngredientSearch").equals("iName")) {
					request.setAttribute("searchIngredient", iName);

					List<Ingredient> name = facade.findByiName(searchIngredient);
					for (Ingredient in1 : name) {
						request.setAttribute("ingredient", in1);

					}
					System.out.println(iName);
					url = "/ShowIngredient.jsp";

				}
				if (request.getParameter("radioIngredientSearch").equals("iQuantityInStock")) {
					request.setAttribute("searchIngredient", iQuantityInStock);

					List<Ingredient> quantity = facade.findByiQuantityInStock(Double.valueOf(searchIngredient));
					for (Ingredient in1 : quantity) {

						request.setAttribute("ingredient", in1);

					}
					url = "/ShowIngredient.jsp";

				}

			}

		} else if (operation.equals("searchIngredient")) {
			System.out.println("CustomerServlet-searchIngredient");
			url = "/searchIngredient.jsp";
		} else {
			url = "/searchIngredient.jsp";
		}
		System.out.println(url);
		RequestDispatcher dispatcher = getServletContext().getRequestDispatcher(url);
		dispatcher.forward(request, response);
	}

}
