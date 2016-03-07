package entityAccess.eao;

import java.util.List;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.TypedQuery;

import entity.ejb.Order;

/**
 * Session Bean implementation class OrderEAOImpl
 */
@Stateless
public class OrderEAOImpl implements OrderEAOImplLocal {

	@PersistenceContext(unitName = "LabEJBSQL")
	private EntityManager em;

	/**
	 * Default constructor.
	 */
	public OrderEAOImpl() {
	}

	@Override
	public Order findByoNumber(String oNumber) {
		return em.find(Order.class, oNumber);
	}

	@Override
	public Order createOrder(Order order) {
		em.persist(order);
		return order;
	}

	
//	@Override
//	public List<Order> updateOrder(Order order){
//		TypedQuery<Order> query = em.createNamedQuery("Order.updateOrder", Order.class);
//		
//		List <Order> o = query.getResultList();
//		if(order.getExpectedDeliveryDate() != null){
//			order.setExpectedDeliveryDate(o.getExpectedDeliveryDate());
//		}
//		if(order.getoNumber() != null){
//			order = o.getoNumber();
//		}
//		return order;
//		
//	}
	
//	@Override
//	public List<Order> updateOrder(String oNumber) {
//		TypedQuery<Order> query = em.createNamedQuery("Order.updateOrder", Order.class);
//		Query.setParameter("oNumber", oNumber);
//		List<Order> results = query.getResultList();
//		
//		for(Order o : results){
//		if(((Order) results).getExpectedDeliveryDate() != null){
//			o.setExpectedDeliveryDate(o.getExpectedDeliveryDate());
//		}}
//		for(Order o : results){
//			if(((Order) results).getCustomer() != null){
//				o.setCustomer(o.getCustomer());
//			}}
//		for(Order o : results){
//			if(((Order) results).getoNumber() != null){
//				o.setoNumber(o.getoNumber());
//			}}
//		for(Order o : results){
//			if(((Order) results).getOrderspecification() != null){
//				o.setExpectedDeliveryDate(o.getExpectedDeliveryDate());
//			}}
//		for(Order o : results){
//			if(((Order) results).getOrderspecification() != null){
//				o.setOrderspecification(o.getOrderspecification());
//			}}
//		
//		return results;
//	}
	
	@Override
	public Order updateOrder(Order order) {
		em.merge(order);
		return order;
	}

	@Override
	public void deleteOrder(String oNumber) {
		Order o = this.findByoNumber(oNumber);
		if (o != null) {
			em.remove(o);
		}
	}

	@Override
	public List<Order> findAllOrders() {
		TypedQuery<Order> query = em.createNamedQuery("Order.findAllOrders", Order.class);
		List<Order> results = query.getResultList();
		return results;
	}

	@Override
	public List<Order> findCertainOrder(String customer) {
		TypedQuery<Order> query = em.createNamedQuery("Order.findCertainOrder", Order.class);
		query.setParameter("customer", customer);
		List<Order> results = query.getResultList();
		return results;
	}

	@Override
	public List<Order> isDelivered(boolean isDelivered) {
		TypedQuery<Order> query = em.createNamedQuery("Order.isDelivered", Order.class);
		query.setParameter("isDelivered", isDelivered);
		List<Order> results = query.getResultList();
		return results;
	}


}