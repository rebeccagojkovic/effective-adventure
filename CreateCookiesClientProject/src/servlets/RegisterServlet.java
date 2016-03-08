package servlets;

import java.io.IOException;

import javax.ejb.EJB;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import entity.ejb.Customer;
import facade.FacadeLocal;

/**
 * Servlet implementation class RegisterServlet
 */
@WebServlet("/RegisterServlet")
public class RegisterServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	@EJB
	FacadeLocal facade;

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		String cEmail = request.getParameter("cEmail");
		String cPassword = request.getParameter("cPassword");
		String cName = request.getParameter("cName");
		String cAddress = request.getParameter("cAddress");
		String cCountry = request.getParameter("cCountry");
		String cPostalAddress = request.getParameter("cPostalAddress");
//		String cNumber = request.getParameter("cNumber");

		Customer c = new Customer(cName, cAddress, cPostalAddress, cCountry, cEmail, cPassword);
		
//		request.getSession().setAttribute("cNumber", c);

//		request.getSession().setAttribute("cName", cName);
//		request.getSession().setAttribute("cPostalAddress", cPostalAddress);
//		request.getSession().setAttribute("cAddress", cAddress);
//		request.getSession().setAttribute("cCountry", cCountry);
//		request.getSession().setAttribute("cEmail", cEmail);
//		request.getSession().setAttribute("cPassword", cPassword);
//		request.getSession().setAttribute("cNumber", cNumber);

//		c.setcAddress(cAddress);
//		c.setcCountry(cCountry);
//		c.setcEmail(cEmail);
//		c.setcName(cName);
//		c.setcPassword(cPassword);
//		c.setcPostalAddress(cPostalAddress);
//		c.setcNumber(cNumber);

		facade.createCustomer(c);

		response.sendRedirect("http://iis.infoteket.nu/CreateCookiesWeb/index.html");

		doGet(request, response);
	}

}
