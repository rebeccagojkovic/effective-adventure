package entityAccess.eao;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

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

	public Order findByoNumber(long oNumber) {
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

	public void deleteOrder(long oNumber) {
		Order o = this.findByoNumber(oNumber);
		if (o != null) {
			em.remove(o);
		}
	}

}
