package servlets;
import javax.ejb.EJB;
import java.io.IOException;
import java.util.List;

import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import entity.ejb.Order;
import facade.FacadeLocal;

/**
 * Servlet implementation class OrderServlet
 */
@WebServlet("/OrderServlet")
public class OrderServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
	@EJB
	FacadeLocal facade;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public OrderServlet() {
		super();
		
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
			String url = null;
		
			String operation = request.getParameter("operation");
			if (operation.equals("showorder")) {
				System.out.println("MainServlet-showorder");

				String oNumber = request.getParameter("orderNumber");
				String isDelivered = request.getParameter("isDelivered");
				

				String searchOrder = request.getParameter("searchOrder");
				
				if (request.getParameter("radioOrderSearch") != null) {
					if (request.getParameter("radioOrderSearch").equals("orderNumber")) {
						request.setAttribute("searchOrder", oNumber);


						System.out.println("findByoNumber");

						Order number = facade.findByoNumber(searchOrder);
						
							request.setAttribute("Order", number);

						url = "/ShowOrder.jsp";
					
					
					}
					if (request.getParameter("radioOrderSearch").equals(isDelivered)) {
						request.setAttribute("searchOrder", isDelivered);

						List<Order> delivered = facade.isDelivered(true);
						for (Order o3 : delivered) {
							request.setAttribute("Order", o3);
						}
						url = "/ShowOrder.jsp";
					}

				} else if (operation.equals("SearchOrder")) {
					System.out.println("OrderServlet-SearchOrder");
					url = "/SearchOrder.jsp";
				} else {
					url = "/SearchOrder.jsp";
				}
				System.out.println(url);
				RequestDispatcher dispatcher = getServletContext().getRequestDispatcher(url);
				dispatcher.forward(request, response);
			}
		}
}
