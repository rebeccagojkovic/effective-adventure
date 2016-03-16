package servlets;

import javax.naming.Context;
import javax.naming.InitialContext;

import entity.ejb.Customer;
import junit.framework.TestCase;

public class CustomerEJBTestTest extends TestCase {
	Customer customer;
	
	public CustomerEJBTestTest(String name) {
		super(name);
		
	}

	protected void setUp() throws Exception {
		super.setUp();
		Context context = new InitialContext();
	    customer=(Customer)context.lookup("java:app/CreateCookiesProject/Customer!entity.ejb.Customer");
	}

	protected void tearDown() throws Exception {
		super.tearDown();
		customer=null;
	}

	public void testGetcNumber() {
		assertEquals(customer.getcNumber(),"1");
	}

	public void testSetcNumber() {
		 customer.setcNumber("1");
	}

	public void testGetcName() {
		assertEquals(customer.getcName(),"Bageriet");
	}

	public void testSetcName() {
		customer.setcName("Bageriet");
	}

	public void testGetcAddress() {
		assertEquals(customer.getcAddress(),"Nygatan");
	}

	public void testSetcAddress() {
		customer.setcAddress("Nygatan");
	}

	public void testGetcPostalAddress() {
		assertEquals(customer.getcPostalAddress(),"Malmö");
	}

	public void testSetcPostalAddress() {
		customer.setcPostalAddress("Lund");
	}
	public void testEquals() {
		 assertTrue(!customer.equals(null));
		 assertEquals(customer,customer);
		 assertEquals(customer, new Customer());
		 assertTrue(!customer.equals(customer));
		}

}
