package servlets;

import java.io.IOException;
import javax.ejb.EJB;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.Cookie;
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

	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		request.setCharacterEncoding("UTF-8");

		String cEmail = request.getParameter("cEmail");
		String cPassword = request.getParameter("cPassword");
		String cName = request.getParameter("cName");
		String cAddress = request.getParameter("cAddress");
		String cCountry = request.getParameter("cCountry");
		String cPostalAddress = request.getParameter("cPostalAddress");
		// String cNumber = request.getParameter("cNumber");

		Customer c = new Customer(cName, cAddress, cPostalAddress, cCountry, cEmail, cPassword);

		facade.createCustomer(c);

		Cookie customerCookie = new Cookie("cEmail", cEmail);
		request.getSession().setAttribute("cEmail", cEmail);

		customerCookie.setMaxAge(60 * 60);
		customerCookie.setPath("/CreateCookiesClientProject");
		response.addCookie(customerCookie);
		response.sendRedirect("http://iis.infoteket.nu/CreateCookiesWeb/profilsida.html");

		doGet(request, response);
	}

}
