package entityAccess.eao;

import java.util.List;

import javax.ejb.Local;

import entity.ejb.Customer;
import entity.ejb.Order;


@Local
public interface OrderEAOImplLocal {
	public Order findByoNumber(long oNumber);

	public Order createOrder(Order order);

	public Order updateOrder(Order order);

	public void deleteOrder(long oNumber);
	
	public List<Order> findCertainOrder(String oNumber);
	
	public List<Order> findAllOrders();
	
}
