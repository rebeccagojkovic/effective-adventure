package servlets;

import javax.naming.Context;
import javax.naming.InitialContext;

import entity.ejb.Customer;
import facade.FacadeLocal;
import junit.framework.TestCase;

public class CustomerTest extends TestCase {
    Customer customer;
	public CustomerTest(String name) {
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
;
	}

	public void testSetcNumber() {
		 customer.setcNumber("1");
	}

	public void testGetcName() {
		 assertEquals(customer.getcName(),"Åke");
	}

	public void testSetcName() {
		 customer.setcName("Åke");
	}

	public void testGetcAddress() {
		 assertEquals(customer.getcAddress(),"Nygatan");
	}

	public void testSetcAddress() {
		customer.setcAddress("Nygatan");
	}

	public void testGetcPostalAddress() {
		 assertEquals(customer.getcPostalAddress(),"Lund");
	}

	public void testSetcPostalAddress() {
		customer.setcPostalAddress("Lund");
	}

}
