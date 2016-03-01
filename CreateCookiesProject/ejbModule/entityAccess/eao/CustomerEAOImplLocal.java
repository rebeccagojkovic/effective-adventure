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

	public List<Customer> findAllCustomers();

	public List<Customer> findByAddress(String cAddress);

	public List<Customer> findByCountry(String cCountry);

	public List<Customer> findByPostalAddress(String cPostalAddress);

	public List<Customer> findBycName(String cName);
	
	public List<Customer> findBycEmail(String cEmail);

}
