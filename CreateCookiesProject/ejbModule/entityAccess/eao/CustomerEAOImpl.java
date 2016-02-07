package entityAccess.eao;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

import entity.ejb.Customer;



/**
 * Session Bean implementation class CustomerEAOImpl
 */
@Stateless
public class CustomerEAOImpl implements CustomerEAOImplLocal {
	
	@PersistenceContext(unitName = "LabEJBSQL")
	private EntityManager em;

	/**
	 * Default constructor.
	 */
	public CustomerEAOImpl() {
		// TODO Auto-generated constructor stub
	}

	public Customer findBycNumber(long cNumber) {
		return em.find(Customer.class, cNumber);

	}

	public Customer createCustomer(Customer customer) {
		em.persist(customer);
		return customer;
	}

	public Customer updateCustomer(Customer customer) {
		em.merge(customer);
		return customer;
	}

	public void deleteCustomer(long cNumber) {
		Customer c = this.findBycNumber(cNumber);
		if (c != null) {
			em.remove(c);
		}
	}

}
