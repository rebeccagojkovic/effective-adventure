package servlets;

import java.util.List;

import javax.naming.Context;
import javax.naming.InitialContext;

import entity.ejb.Customer;
import facade.FacadeLocal;
import junit.framework.TestCase;

public class CustomerEJBTest extends TestCase {
	FacadeLocal facade;
	public CustomerEJBTest(String name) {
		super(name);
	}

	protected void setUp() throws Exception {
		super.setUp();
		Context context = new InitialContext();
		facade=(FacadeLocal)context.lookup("java:app/CreateCookiesProject/Facade!facade.FacadeLocal");
	}

	protected void tearDown() throws Exception {
		super.tearDown();
		facade=null;
	}

	public void testFindByAddress() {
		List<Customer>addresslist=facade.findByAddress("Nygatan");
		assertEquals(facade.findByAddress("Nygatan"), addresslist);
	}

	public void testFindByCountry(List<Customer>countrylist) {
		countrylist=facade.findByCountry("Sweden");
		assertEquals(facade.findByCountry("Sweden"),countrylist);
	}

	public void testFindByPostalAddress(List<Customer>postalAddresslist) {
		postalAddresslist=facade.findByPostalAddress("Lund");
		assertEquals(facade.findByPostalAddress("Lund"),postalAddresslist);
	}

	public void testFindBycName(List<Customer>name) {
		name=facade.findBycName("Bageriet");
		assertEquals(facade.findBycName("Bageriet"),name);
	}

	public void testFindBycEmail(List<Customer>emaillist) {
		emaillist=facade.findBycEmail("ake@bageriet.se");
		assertEquals(facade.findBycEmail("ake@bageriet.se"),emaillist);
	}

}
