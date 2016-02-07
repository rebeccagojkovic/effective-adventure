package entityAccess.eao;

import javax.ejb.Local;

import entity.ejb.Order;


@Local
public interface OrderEAOImplLocal {
	public Order findByoNumber(long oNumber);

	public Order createOrder(Order order);

	public Order updateOrder(Order order);

	public void deleteOrder(long oNumber);
}
