package servlets;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Timestamp;
import java.util.List;
import javax.ejb.EJB;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import entity.ejb.Product;
import facade.FacadeLocal;

/**
 * Servlet implementation class ProduktServlet
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
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		request.setCharacterEncoding("UTF-8");

		response.getWriter().append("Served at: ").append(request.getContextPath());
		PrintWriter out = response.getWriter();
		out.println("ProductServlet-doGet");
		out.close();
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		request.setCharacterEncoding("UTF-8");
		// doGet(request, response);
		String url = null;
		// Get hidden field
		String operation = request.getParameter("operation");
		if (operation.equals("showproduct")) {
			System.out.println("MainServlet-showproduct");

//			String pNumber = request.getParameter("productNumber");
			String pName = request.getParameter("productName");
			String pTime = request.getParameter("productTime");
			

			String searchProduct = request.getParameter("searchProduct");

			if (request.getParameter("radioproductsearch") != null) {
//				if (request.getParameter("radioproductsearch").equals("productNumber")) {
//					request.setAttribute("searchProduct", pNumber);
//
//					Product number = facade.findBypNumber(searchProduct);
//					
//					request.setAttribute("product", number);
//
//					System.out.println("findBypNumber");
//
//					url = "/ShowProduct.jsp";
//				}
				if (request.getParameter("radioproductsearch").equals("productName")) {
					request.setAttribute("searchProduct", pName);

					List<Product> name = facade.findBypName(searchProduct);
					for (Product p2 : name) {
						request.setAttribute("product", p2);

					}
					url = "/ShowProduct.jsp";

				}
				if (request.getParameter("radioproductsearch").equals("productTime")) {
					request.setAttribute("searchProduct", pTime);

					List<Product> time = facade.InfoTimeStamp(Timestamp
							.valueOf(searchProduct));
					for (Product p3 : time) {
						request.setAttribute("product", p3);

					}
					url = "/ShowProduct.jsp";

				}
			} else if (operation.equals("SearchProduct")) {
				System.out.println("CustomerServlet-SearchProduct");
				url = "/SearchProduct.jsp";
			} else {
				url = "/SearchProduct.jsp";
			}
			System.out.println(url);
			RequestDispatcher dispatcher = getServletContext().getRequestDispatcher(url);
			dispatcher.forward(request, response);
		}

	}

}
