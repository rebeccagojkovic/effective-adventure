package servlets;

import javax.ejb.EJB;
import javax.servlet.*;
import java.io.PrintWriter;
import java.util.List;
import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.RequestDispatcher;
import facade.FacadeLocal;
import entity.ejb.*;

@WebServlet("/MainServlet")
public class MainServlet extends HttpServlet {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private static final String CONTENT_TYPE = "text/html; charset=ISO-8859-1";

	@EJB
	FacadeLocal facade;

	public void init(ServletConfig config) throws ServletException {
		super.init(config);
	}

	public void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		response.setContentType(CONTENT_TYPE);
		PrintWriter out = response.getWriter();
		out.println("MainServlet-doGet");
		out.close();
	}

	public void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		response.setContentType(CONTENT_TYPE);
		String url = null; // Get hidden field
		String operation = request.getParameter("operation");
		if (operation.equals("showemail")) {
			String cEmail = request.getParameter("txtEmail");

			// Customer customeremail = facade.getCustomerByEmail(cEmail);

			List<Customer> allcustomers = facade.findBycEmail(cEmail);
			for (Customer cu1 : allcustomers) {
				
				request.setAttribute("email", cu1.getcEmail());
				
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
		dispatcher.forward(request, response);// request.getRequestDispatcher(url).forward(request,
		// response);
	}
}