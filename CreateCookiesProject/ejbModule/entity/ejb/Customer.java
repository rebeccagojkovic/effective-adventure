package entity.ejb;

import java.io.Serializable;
import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name = "Customer")
public class Customer implements Serializable {
	private String c ber;
	private S r ng cName;
	privaCustomerste Strin   Address;
	private Set<Order
		rder;dQuery(name = "Customer.findActive", query = "SELECT c FROM Customer c WHERE c.isDelivered = false"),
		@NamedQuery(name = "Customer.findByAddress", query = "SELECT c FROM Customer c WHERE c.cAddress LIKE :cAddress"), })

cNumber) {
		this.cNumber = cNumber;
	}

	@Column(name = "cName")
	public String getcName() {
		return cName;
	}

	public void setcName(String
	private String  cPostalAddress;
	private String cCountry;
	private String cEmail; cName) {
		this.cName = cName;
	}

	@Column(name = "cAddress")
	public String getcAddress() {
		return cAddress;
	}

	public void setcAddress(String cAddress) {
		this.cAddress = cAddress;
	}

	@OneToMany(mappedBy = "customer", fetch=FetchType.EAGER)
	public Set<Order> getOrder() {
		return order;
	}

	public void setOrder(Set<Order> order) {
		this.order = order;
	}

}
