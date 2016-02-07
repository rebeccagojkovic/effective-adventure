package entity.ejb;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.JoinTable;
import javax.persistence.ManyToMany;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "Orde")
public class Order {
	private long oNumber;
	private boolean isDelivered;
	private int expectedDeliveryDate;
	private Set<Product> products;
	private Customer customer;

	@Id
	@Column(name = "oNumber")
	public long getoNumber() {
		return oNumber;
	}

	public void setoNumber(long oNumber) {
		this.oNumber = oNumber;
	}

	@Column(name = "isDelivered")
	public boolean isDelivered() {
		return isDelivered;
	}

	public void setDelivered(boolean isDelivered) {
		this.isDelivered = isDelivered;
	}

	@Column(name = "expectedDeliveryDate")
	public int getExpectedDeliveryDate() {
		return expectedDeliveryDate;
	}

	public void setExpectedDeliveryDate(int expectedDeliveryDate) {
		this.expectedDeliveryDate = expectedDeliveryDate;
	}

	@ManyToMany
	@JoinTable(name = "Orderspecification", joinColumns = @JoinColumn(name = "oNumber", referencedColumnName = "oNumber"), inverseJoinColumns = @JoinColumn(name = "pNumber", referencedColumnName = "pNumber"))
	public Set<Product> getProducts() {
		return products;
	}

	public void setProducts(Set<Product> products) {
		this.products = products;
	}

	@ManyToOne
	@JoinColumn(name = "cNumber", referencedColumnName = "cNumber")
	public Customer getCustomer() {
		return customer;
	}

	public void setCustomer(Customer customer) {
		this.customer = customer;
	}

}
