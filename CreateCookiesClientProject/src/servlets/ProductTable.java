package servlets;

import java.io.IOException;
import java.util.List;
import javax.ejb.EJB;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import entity.ejb.Product;
import facade.FacadeLocal;

/**
 * Servlet implementation class ProductServlet
 */
@WebServlet("/ProductTable")
public class ProductTable extends HttpServlet {
	private static final long serialVersionUID = 1L;
	@EJB
	FacadeLocal facade;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public ProductTable() {
		super();
		// TODO Auto-generated constructor stub
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		System.out.println("MainServlet-showproduct");
		List<Product> products = facade.findAllProducts();
		request.setAttribute("products", products);
		request.getRequestDispatcher("AllProductsJSON.jsp").forward(request, response);
	}
}
