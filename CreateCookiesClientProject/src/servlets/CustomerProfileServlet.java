package servlets;

import java.io.IOException;
import java.util.List;

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
 * Servlet implementation class CustomerProfile
 */
@WebServlet("/CustomerProfileServlet")
public class CustomerProfileServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	@EJB
	FacadeLocal facade;   
    /**
     * @see HttpServlet#HttpServlet()
     */
    public CustomerProfileServlet() {
        super();
        // TODO Auto-generated constructor stub
    }

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		request.setCharacterEncoding("UTF-8");

		Cookie[] cookies = request.getCookies();

		for (Cookie cookie : cookies) {
			if ("cEmail".equals(cookie.getName())) {
				String cEmail = cookie.getValue();

				List<Customer> customer = facade.findBycEmail(cEmail);
				for (Customer cu1 : customer) {
					request.setAttribute("cNumber", cu1.getcNumber());
					request.setAttribute("cEmail", cu1.getcEmail());
					request.setAttribute("cPassword", cu1.getcPassword());
					request.setAttribute("cName", cu1.getcName());
					request.setAttribute("cAddress", cu1.getcAddress());
					request.setAttribute("cCountry", cu1.getcCountry());
					request.setAttribute("cPostalAddress", cu1.getcPostalAddress());
					request.getRequestDispatcher("CustomerProfile.jsp").forward(request, response);
				}
			}
		}
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		request.setCharacterEncoding("UTF-8");

		String cEmail = request.getParameter("cEmail");
		String cPassword = request.getParameter("cPassword");
		String cName = request.getParameter("cName");
		String cAddress = request.getParameter("cAddress");
		String cCountry = request.getParameter("cCountry");
		String cPostalAddress = request.getParameter("cPostalAddress");
		String cNumber = request.getParameter("cNumber");

		Customer c = new Customer(cNumber, cName, cAddress, cPostalAddress, cCountry, cEmail, cPassword);

		facade.updateCustomer(c);

		Cookie customerCookie = new Cookie("cEmail", cEmail);
		request.getSession().setAttribute("cEmail", cEmail);

		customerCookie.setMaxAge(60 * 60);
		customerCookie.setPath("/CreateCookiesClientProject");
		response.addCookie(customerCookie);
		response.sendRedirect("http://iis.infoteket.nu/CreateCookiesWeb/profilsida.html");

		doGet(request, response);
	}

}
