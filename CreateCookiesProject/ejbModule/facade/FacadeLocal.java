package facade;

import javax.ejb.Local;

import entity.ejb.Customer;
import entity.ejb.Ingredient;

@Local
public interface FacadeLocal {
	
	public Customer createCustomer(Customer customer);
	
	public Customer findBycNumber(long cNumber);
	
	public Customer updateCustomer(Customer customer);
	
	public void deleteCustomer(long cNumber);
	
	public Ingredient findByiNumber(int iNumber);
	
	public Ingredient createIngredient(Ingredient ingredient);
	
	public Ingredient updateIngredient(Ingredient ingredient);
	
	public void deleteIngredient(int iNumber);

}
