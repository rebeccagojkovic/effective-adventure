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

import entity.ejb.Customer;
import entity.ejb.Product;
import facade.FacadeLocal;

/**
 * Servlet implementation class ProductServlet
 */
@WebServlet("/ProductServlet")
public class ProductServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	@EJB
	FacadeLocal facade;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public ProductServlet() {
		super();
		// TODO Auto-generated constructor stub
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// doGet(request, response);
		String url = null;
		// Get hidden field
		String operation = request.getParameter("operation");
		if (operation.equals("showproduct")) {
			System.out.println("MainServlet-showproduct");

			String pName = request.getParameter("productName");

			String searchProduct = request.getParameter("searchProduct");

			if (request.getParameter("radioproductsearch") != null) {
				if (request.getParameter("radioproductsearch").equals("productName")) {
					request.setAttribute("searchProduct", pName);

					System.out.println("findAllProducts");

					List<Product> name = facade.findAllProducts();
					request.setAttribute("product", name);

					url = "/ProductTable.jsp";
				}

			}
		} else if (operation.equals("SearchProduct")) {
			System.out.println("ProductServlet-SearchProduct");
			url = "/SearchProduct.jsp";
		} else {
			url = "/SearchProduct.jsp";
		}
		System.out.println(url);
		RequestDispatcher dispatcher = getServletContext().getRequestDispatcher(url);
		dispatcher.forward(request, response);

	}
}
