package servlets;

import java.io.IOException;


import javax.ejb.EJB;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;


import entity.ejb.Recipe;
import facade.FacadeLocal;

/**
 * Servlet implementation class RecipeServlet
 */
@WebServlet("/RecipeServlet")
public class RecipeServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	@EJB
	FacadeLocal facade;

    public RecipeServlet() {
        super();
       
    }

	
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		request.setCharacterEncoding("UTF-8");

		String url = null;
		String operation = request.getParameter("operation");
		if (operation.equals("showRecipe")) {
			System.out.println("MainServlet-showRecipe");

			String pNumber = request.getParameter("pNumber");
			String iNumber = request.getParameter("iNumber");
			String iNumberPNumber = request.getParameter("iNumberPNumber");

			String searchRecipe = request.getParameter("searchRecipe");

			if (request.getParameter("radioRecipe") != null) {
				if (request.getParameter("radioRecipeSearch").equals("iNumberPNumber")) {
					request.setAttribute("searchIngredient", iNumber);

					Recipe number = facade.findByiNumberPNumber(iNumber, pNumber);

					request.setAttribute("Recipe", number);

					System.out.println(iNumberPNumber);
					url = "/ShowRecipe.jsp";
				}
							}

		} else if (operation.equals("searchRecipe")) {
			System.out.println("CustomerServlet-searchRecipe");
			url = "/searchRecipe.jsp";
		} else {
			url = "/searchRecipe.jsp";
		}
		System.out.println(url);
		RequestDispatcher dispatcher = getServletContext().getRequestDispatcher(url);
		dispatcher.forward(request, response);
	}

}