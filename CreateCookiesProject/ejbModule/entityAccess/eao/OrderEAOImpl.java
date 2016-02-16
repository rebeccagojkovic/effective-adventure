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

	public Order findByoNumber(String oNumber) {
		return em.find(Order.class, oNumber);
	}

	public Order createOrder(Order order) {
		em.persist(order);
		return order;
	}

	public Order updateOrder(Order order) {
		em.merge(order);
		return order;
	}

	public void deleteOrder(String oNumber) {
		Order o = this.findByoNumber(oNumber);
		if (o != null) {
			em.remove(o);
		}
	}

//	public List<Order> findAllOrders() {
//		TypedQuery<Order> query = em.createNamedQuery("Order.findAllOrders", Order.class);
//		List<Order> results = query.getResultList();
//		return results;
//	}
//
//	public List<Order> findCertainOrder(String oNumber) {
//		TypedQuery<Order> query = em.createNamedQuery("Order.findCertainOrder", Order.class);
//		query.setParameter("oNumber", oNumber);
//		List<Order> results = query.getResultList();
//		return results;
//
//	}

}