package servlets;

import java.util.List;
import javax.naming.Context;
import javax.naming.InitialContext;
import entity.ejb.Customer;
import facade.FacadeLocal;
import junit.framework.TestCase;

public class CustomerEJBTest extends TestCase {
	FacadeLocal facade;

	String expectedNumber;
	String expectedName;
	String expectedAddress;
	String expectedPostalAddress;
	String expectedCountry;
	String expectedEmail;
	String expectedPassword;

	Customer c1;
	Customer c2;

	public CustomerEJBTest(String name) {
		super(name);

	}

	protected void setUp() throws Exception {
		super.setUp();
		Context context = new InitialContext();
		facade = (FacadeLocal) context.lookup("java:app/CreateCookiesProject/Facade!facade.FacadeLocal");

		expectedNumber = "1";
		expectedName = "Bageriet";
		expectedAddress = "Nygatan";
		expectedPostalAddress = "Lund";
		expectedCountry = "Sweden";
		expectedEmail = "ake@bageriet.se";
		expectedPassword = "password";

		c1 = new Customer(expectedNumber, expectedName, expectedAddress, expectedPostalAddress, expectedCountry, expectedEmail,
				expectedPassword);
	}

	protected void tearDown() throws Exception {
		super.tearDown();
		facade = null;
		c1 = null;
	}

	public void testFindByAddress() {
		List<Customer> addresslist = facade.findByAddress(expectedAddress);
		for (Customer cu1 : addresslist) {
			assertEquals(expectedAddress, cu1.getcAddress());
		}

	}

	public void testFindByCountry() {
		List<Customer> countrylist = facade.findByCountry(expectedCountry);
		for (Customer cu1 : countrylist) {
			assertEquals(expectedCountry, cu1.getcCountry());
		}

	}

	public void testFindByPostalAddress() {
		List<Customer> postalAddresslist = facade.findByPostalAddress(expectedPostalAddress);
		for (Customer cu1 : postalAddresslist) {
			assertEquals(expectedPostalAddress, cu1.getcPostalAddress());
		}

	}

	public void testFindBycName() {
		List<Customer> name = facade.findBycName(expectedName);
		for (Customer cu1 : name) {
			assertEquals(expectedName, cu1.getcName());
		}
	}

	public void testFindBycEmail() {
		List<Customer> emaillist = facade.findBycEmail(expectedEmail);
		for (Customer cu1 : emaillist) {
			assertEquals(expectedEmail, cu1.getcEmail());	
		}
		
	}

	public void testEquals() {
		assertTrue(!facade.equals(null));
		assertEquals(facade, facade);
		// assertTrue(!facade.equals(facade));

	}

}
