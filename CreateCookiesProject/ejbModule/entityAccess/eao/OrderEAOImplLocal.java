package entityAccess.eao;

import java.util.List;

import javax.ejb.Local;

import entity.ejb.Customer;
import entity.ejb.Order;

@Local
public interface OrderEAOImplLocal {
	public Order findByoNumber(String oNumber);

	public Order createOrder(Order order);

	public Order updateOrder(Order order);

	public void deleteOrder(String oNumber);

	public List<Order> findCertainOrder(String customer);

	public List<Order> isDelivered(boolean isDeliverd);

	public List<Order> findAllOrders();

}
