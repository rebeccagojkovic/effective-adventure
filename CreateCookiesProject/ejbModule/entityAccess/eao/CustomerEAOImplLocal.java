package entityAccess.eao;

import java.util.List;

import javax.ejb.Local;

import entity.ejb.Customer;

@Local
public interface CustomerEAOImplLocal {
	public Customer findBycNumber(String cNumber);

	public Customer createCustomer(Customer customer);

	public Customer updateCustomer(Customer customer);

	public void deleteCustomer(String cNumber);

//	public List<Customer> findActive(Boolean isDelivered);

//	public List<Customer> findAllCustomers();

}
