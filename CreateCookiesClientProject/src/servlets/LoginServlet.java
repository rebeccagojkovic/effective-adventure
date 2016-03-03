package servlets;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import entity.ejb.*;
import entityAccess.eao.*;
import facade.FacadeLocal;

public class LoginServlet extends HttpServlet {
	public void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {

		String cEmail = request.getParameter("cEmail");
		String cPassword = request.getParameter("cPassword");
		CustomerEAOImpl loginService = new CustomerEAOImpl();
		boolean result = loginService.authenticateCustomer(cEmail, cPassword);
		Customer customer = loginService.getCustomerByEmail(cEmail);
		if (result == true) {
			request.getSession().setAttribute("customer", customer);
			response.sendRedirect("home.jsp");
		} else {
			response.sendRedirect("error.jsp");
		}
	}

}