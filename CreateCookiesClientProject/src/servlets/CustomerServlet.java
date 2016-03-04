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
		// TODO Auto-generated constructor stub
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// TODO Auto-generated method stub
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
		// TODO Auto-generated method stub
		// doGet(request, response);
		String url = null;
		// Get hidden field
		String operation = request.getParameter("operation");
		if (operation.equals("showcustomer")) {
			System.out.println("MainServlet-showcustomer");
			
			
			String cName = request.getParameter("companyName");
			String cEmail = request.getParameter("email");
			String cCountry = request.getParameter("country");
			String cPostalAddress = request.getParameter("postalAddress");
			String cAddress = request.getParameter("address");

			String searchCustomer = request.getParameter("searchCustomer");

			if (request.getParameter("radiocustomersearch") != null) {
				if (request.getParameter("radiocustomersearch").equals("companyName")) {
					request.setAttribute("searchCustomer", cName);
					
					System.out.println("findBycName");
					
					List<Customer> name = facade.findBycName(searchCustomer);
					for (Customer cu1 : name) {
						request.setAttribute("customer", cu1.getcEmail());
						
					}
					url = "/ShowCustomer.jsp";
				}
				// else {
				// request.setAttribute("Radio button 1 was not selected.<BR>",
				// );
				// }
				// if(request.getParameter("radios").equals("radio2")) {
				// request.setAttribute("Radio button 2 was selected.<BR>");
				// }
				// else {
				// out.println("Radio button 2 was not selected.<BR>");
				// }
				// if(request.getParameter("radios").equals("radio3")) {
				// out.println("Radio button 3 was selected.<BR>");
				// }
				// else {
				// out.println("Radio button 3 was not selected.<BR>");
				// }
				//
				
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
