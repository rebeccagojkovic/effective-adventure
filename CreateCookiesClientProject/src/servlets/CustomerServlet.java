package servlets;

import java.io.IOException;

import javax.ejb.EJB;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.io.PrintWriter;
import java.util.List;

import entity.ejb.Customer;
import facade.FacadeLocal;

/**
 * Servlet implementation class CustomerServlet
 */
@WebServlet("/CustomerServlet")
public class CustomerServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	@EJB
	FacadeLocal facade;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public CustomerServlet() {
		super();
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// response.getWriter().append("Served at:
		// ").append(request.getContextPath());
		PrintWriter out = response.getWriter();
		out.println("CustomerServlet-doGet");
		out.close();

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
		if (operation.equals("showcustomer")) {
			System.out.println("MainServlet-showcustomer");

			String cName = request.getParameter("companyName");
			String cEmail = request.getParameter("companyEmail");
			String cCountry = request.getParameter("companyCountry");
			String cPostalAddress = request.getParameter("companyPostalAddress");
			String cAddress = request.getParameter("companyAddress");

			String searchCustomer = request.getParameter("searchCustomer");
			
			if (request.getParameter("radiocustomersearch") != null) {
				if (request.getParameter("radiocustomersearch").equals("companyName")) {
					request.setAttribute("searchCustomer", cName);

					System.out.println("findBycName");

					List<Customer> name = facade.findBycName(searchCustomer);
					for (Customer cu1 : name) {
						request.setAttribute("customer", cu1);

					}
					url = "/ShowCustomer.jsp";
				}
				if (request.getParameter("radiocustomersearch").equals("companyEmail")) {
					request.setAttribute("searchCustomer", cEmail);

					List<Customer> email = facade.findBycEmail(searchCustomer);
					for (Customer cu2 : email) {
						request.setAttribute("customer", cu2);

					}
					url = "/ShowCustomer.jsp";

				}
				if (request.getParameter("radiocustomersearch").equals("companyCountry")) {
					request.setAttribute("searchCustomer", cCountry);

					List<Customer> country = facade.findByCountry(searchCustomer);
					for (Customer cu3 : country) {
						request.setAttribute("customer", cu3);

					}
					url = "/ShowCustomer.jsp";

				}
				if (request.getParameter("radiocustomersearch").equals("companyPostalAddress")) {
					request.setAttribute("searchCustomer", cPostalAddress);

					List<Customer> postal = facade.findByPostalAddress(searchCustomer);
					for (Customer cu4 : postal) {
						request.setAttribute("customer", cu4);

					}
					url = "/ShowCustomer.jsp";

				}
				if (request.getParameter("radiocustomersearch").equals("companyAddress")) {
					request.setAttribute("searchCustomer", cAddress);

					List<Customer> address = facade.findByAddress(searchCustomer);
					for (Customer cu5 : address) {
						request.setAttribute("customer", cu5);

					}
					url = "/ShowCustomer.jsp";

				}

			} else if (operation.equals("SearchCustomer")) {
				System.out.println("CustomerServlet-SearchCustomer");
				url = "/SearchCustomer.jsp";
			} else {
				url = "/SearchCustomer.jsp";
			}
			System.out.println(url);
			RequestDispatcher dispatcher = getServletContext().getRequestDispatcher(url);
			dispatcher.forward(request, response);
		}

	}
}
