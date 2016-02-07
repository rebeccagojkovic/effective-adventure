package entityAccess.eao;

import javax.ejb.Local;

import entity.ejb.Customer;

@Local
public interface CustomerEAOImplLocal {
	public Customer findBycNumber(long cNumber);

	public Customer createCustomer(Customer customer);

	public Customer updateCustomer(Customer customer);

	public void deleteCustomer(long cNumber);

}
