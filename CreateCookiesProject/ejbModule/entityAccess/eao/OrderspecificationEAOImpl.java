package entityAccess.eao;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

import entity.ejb.Orderspecification;
import entity.ejb.Recipe;

/**
 * Session Bean implementation class OrderspecificationEAOImpl
 */
@Stateless
public class OrderspecificationEAOImpl implements
		OrderspecificationEAOImplLocal {

	@PersistenceContext(unitName = "LabEJBSQL")
	private EntityManager em;

	/**
	 * Default constructor.
	 */
	public OrderspecificationEAOImpl() {
		// TODO Auto-generated constructor stub
	}

	public Orderspecification findBypNumberONumber(int pNumber, long oNumber) {
		return em.find(Orderspecification.class, pNumber, oNumber);

	}

	public Orderspecification createOrderspecification(
			Orderspecification orderspecification) {
		em.persist(orderspecification);
		return orderspecification;
	}

	public Orderspecification updateOrderspecification(
			Orderspecification orderspecification) {
		em.merge(orderspecification);
		return orderspecification;
	}

	public void deleteOrderspecification(int pNumber, long oNumber) {
		Orderspecification os = this.findBypNumberONumber(pNumber, oNumber);
		if (os != null) {
			em.remove(os);
		}
	}

}
