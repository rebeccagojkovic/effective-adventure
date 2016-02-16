package entityAccess.eao;

import java.util.List;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.TypedQuery;

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

	public Customer findBycNumber(String cNumber) {
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

	public void deleteCustomer(String cNumber) {
		Customer c = this.findBycNumber(cNumber);
		if (c != null) {
			em.remove(c);
		}
	}

//	public List<Customer> findAllCustomers() {
//		TypedQuery<Customer> query = em.createNamedQuery("Customer.findAllCustomers", Customer.class);
//		List<Customer> results = query.getResultList();
//		return results;
//	}
//
//	public List<Customer> findActive(Boolean isDelivered) {
//		TypedQuery<Customer> query = em.createNamedQuery(Customer.findActive, Customer.class);
//		// query.setParameter("false", false)
//		List<Customer> results = query.getResultList();
//		return results;
//	}

}
