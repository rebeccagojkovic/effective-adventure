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
		@NamedQuery(name = "Customer.findActive", query = "SELECT c FROM Customer c WHERE c.isDelivered = false"),
		@NamedQuery(name = "Customer.findByAddress", query = "SELECT c FROM Customer c WHERE c.cAddress LIKE :cAddress"), })

@Table(name = "Customer")
public class Customer implements Serializable {
	private String cNumber;
	private String cName;
	private String cAddress;
	private Set<Order> order;

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

	@OneToMany(mappedBy = "customer", fetch = FetchType.EAGER)
	public Set<Order> getOrder() {
		return order;
	}

	public void setOrder(Set<Order> order) {
		this.order = order;
	}

}
