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
import facade.FacadeLocal;

/**
 * Servlet implementation class TestServlet
 */
@WebServlet("/TestServlet")
public class TestServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;

	@EJB
	FacadeLocal facade;

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String url = null; // Get hidden field
		String operation = request.getParameter("operation");
		if (operation.equals("showemail")) {
			String cEmail = request.getParameter("txtEmail");

			// Customer customeremail = facade.getCustomerByEmail(cEmail);

			List<Customer> allcustomers = facade.findBycEmail(cEmail);
			for (Customer cu1 : allcustomers) {

				request.setAttribute("cEmail", cu1.getcEmail());
				request.setAttribute("cName", cu1.getcName());

			}
			url = "/ShowEmail.jsp";

			// Customer c = new Customer();
			// request.setAttribute("email", c);
			// url = "/ShowEmail.jsp";

		} else if (operation.equals("searchemail")) {
			url = "/SearchEmail.jsp";
		} else {
			url = "/SearchEmail.jsp";
		}

		RequestDispatcher dispatcher = getServletContext().getRequestDispatcher(url);
		dispatcher.forward(request, response);
	}

}
