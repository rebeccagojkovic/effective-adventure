package facade;

import javax.ejb.Local;

import entity.ejb.Customer;

@Local
public interface FacadeLocal {
	
	public Customer createCustomer(Customer customer);

}
