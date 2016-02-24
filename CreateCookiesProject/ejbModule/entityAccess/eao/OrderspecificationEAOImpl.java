package entityAccess.eao;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

import entity.ejb.Orderspecification;
import entity.ejb.OrderspecificationId;

/**
 * Session Bean implementation class OrderspecificationEAOImpl
 */
@Stateless
public class OrderspecificationEAOImpl implements OrderspecificationEAOImplLocal {

	@PersistenceContext(unitName = "LabEJBSQL")
	private EntityManager em;

	/**
	 * Default constructor.
	 */
	public OrderspecificationEAOImpl() {
	}

	@Override
	public Orderspecification findBypNumberONumber(String pNumber, String oNumber) {
		OrderspecificationId pNumberONumber = new OrderspecificationId(pNumber, oNumber);
		return em.find(Orderspecification.class, pNumberONumber);

	}

	@Override
	public Orderspecification createOrderspecification(Orderspecification orderspecification) {
		em.persist(orderspecification);
		return orderspecification;
	}

	@Override
	public Orderspecification updateOrderspecification(Orderspecification orderspecification) {
		em.merge(orderspecification);
		return orderspecification;
	}

	@Override
	public void deleteOrderspecification(String pNumber, String oNumber) {
		Orderspecification os = this.findBypNumberONumber(pNumber, oNumber);
		if (os != null) {
			em.remove(os);
		}
	}

}
