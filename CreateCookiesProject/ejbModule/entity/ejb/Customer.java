package entity.ejb;

import java.io.Serializable;
import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity

@NamedQueries({ @NamedQuery(name = "Customer.findAllCustomers", query = "SELECT c FROM Customer c"),
		@NamedQuery(name = "Customer.findByAddress", query = "SELECT c FROM Customer c WHERE c.cAddress LIKE :cAddress"),
		@NamedQuery(name = "Customer.findByCountry", query = "SELECT c FROM Customer c WHERE c.cCountry LIKE :cCountry"),
		@NamedQuery(name = "Customer.findByPostalAddress", query = "SELECT c FROM Customer c WHERE c.cPostalAddress LIKE :cPostalAddress"),
		@NamedQuery(name = "Customer.findBycName", query = "SELECT c FROM Customer c WHERE c.cName LIKE :cName"),
		@NamedQuery(name = "Customer.findBycEmail", query = "SELECT c FROM Customer c WHERE c.cEmail LIKE :cEmail"), })

@Table(name = "Customer")

public class Customer implements Serializable {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private String cNumber;
	private String cName;
	private String cAddress;
	private String cPostalAddress;
	private String cCountry;
	private String cEmail;
	private String cPassword;
	private Set<Order> order;
	
	
	public Customer(String cName, String cAddress, String cPostalAddress, String cCountry, String cEmail, String cPassword) {
		this.cName = cName;
		this.cAddress = cAddress;
		this.cPostalAddress = cPostalAddress;
		this.cCountry = cCountry;
		this.cEmail = cEmail;
		this.cPassword = cPassword;
	}

	@Id
	@Column(name = "cNumber")
	public String getcNumber() {
		return cNumber;
	}

	public void setcNumber(String cNumber) {
		this.cNumber = cNumber;
	}

	@Column(name = "cName")
	public String getcName() {
		return cName;
	}

	public void setcName(String cName) {
		this.cName = cName;
	}

	@Column(name = "cAddress")
	public String getcAddress() {
		return cAddress;
	}

	public void setcAddress(String cAddress) {
		this.cAddress = cAddress;
	}

	@Column(name = "cPostalAddress")
	public String getcPostalAddress() {
		return cPostalAddress;
	}

	public void setcPostalAddress(String cPostalAddress) {
		this.cPostalAddress = cPostalAddress;
	}

	@Column(name = "cCountry")
	public String getcCountry() {
		return cCountry;
	}

	public void setcCountry(String cCountry) {
		this.cCountry = cCountry;
	}

	@Column(name = "cEmail")
	public String getcEmail() {
		return cEmail;
	}

	public void setcEmail(String cEmail) {
		this.cEmail = cEmail;
	}

	@Column(name = "cPassword")
	public String getcPassword() {
		return cPassword;
	}

	public void setcPassword(String cPassword) {
		this.cPassword = cPassword;
	}

	@OneToMany(mappedBy = "customer", fetch = FetchType.EAGER)
	public Set<Order> getOrder() {
		return order;
	}

	public void setOrder(Set<Order> order) {
		this.order = order;
	}

	// @OneToOne(mappedBy = "customer")
	// public Password getPassword() {
	// return password;
	// }
	//
	// public void setPassword(Password password) {
	// this.password = password;
	// }

}
