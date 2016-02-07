package entity.ejb;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name="Customer")
public class Customer {
	private long cNumber;
	private String cName;
	private String cAddress;
	private Set<Order> orders;
	
	@Id
	@Column(name="cNumber")
	public long getcNumber() {
		return cNumber;
	}

	public void setcNumber(long cNumber) {
		this.cNumber = cNumber;
	}
	@Column(name="cName")
	public String getcName() {
		return cName;
	}

	public void setcName(String cName) {
		this.cName = cName;
	}
	@Column(name="cAddress")
	public String getcAddress() {
		return cAddress;
	}

	public void setcAddress(String cAddress) {
		this.cAddress = cAddress;
	}
	@OneToMany(mappedBy="customers")
	public Set<Order> getOrders() {
		return orders;
	}

	public void setOrders(Set<Order> orders) {
		this.orders = orders;
	}
}
