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
	}

	@Override
	public Customer findBycNumber(String cNumber) {
		return em.find(Customer.class, cNumber);

	}

	@Override
	public Customer createCustomer(Customer customer) {
		em.persist(customer);
		return customer;
	}

	@Override
	public Customer updateCustomer(Customer customer) {
		em.merge(customer);
		return customer;
	}

	@Override
	public void deleteCustomer(String cNumber) {
		Customer c = this.findBycNumber(cNumber);
		if (c != null) {
			em.remove(c);
		}
	}

	@Override
	public List<Customer> findAllCustomers() {
		TypedQuery<Customer> query = em.createNamedQuery("Customer.findAllCustomers", Customer.class);
		List<Customer> results = query.getResultList();
		return results;
	}

	@Override
	public List<Customer> findByCountry(String cCountry) {
		TypedQuery<Customer> query = em.createNamedQuery("Customer.findByCountry", Customer.class);
		query.setParameter("cCountry", cCountry);
		List<Customer> results = query.getResultList();
		return results;
	}

	@Override
	public List<Customer> findByAddress(String cAddress) {
		TypedQuery<Customer> query = em.createNamedQuery("Customer.findByAddress", Customer.class);
		query.setParameter("cAddress", cAddress);
		List<Customer> results = query.getResultList();
		return results;
	}
	@Override
	public List<Customer> findByPostalAddress(String cPostalAddress) {
		TypedQuery<Customer> query = em.createNamedQuery("Customer.findByPostalAddress", Customer.class);
		query.setParameter("cPostalAddress", cPostalAddress);
		List<Customer> results = query.getResultList();
		return results;
	}

	@Override
	public List<Customer> findBycName(String cName) {
		TypedQuery<Customer> query = em.createNamedQuery("Customer.findBycName", Customer.class);
		query.setParameter("cName", cName);
		List<Customer> results = query.getResultList();
		return results;
	}


}
