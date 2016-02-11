package entity.ejb;

import java.text.DateFormat;
import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name = "Order")
public class Order {
	private String oNumber;
	private boolean isDelivered;
	private DateFormat expectedDeliveryDate;
	private Customer customer;
	private Set<Orderspecification> orderspecification;
	
	@Id
	@Column(name = "oNumber")
	public String getoNumber() {
		return oNumber;
	}

	public void setoNumber(String oNumber) {
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
	public DateFormat getExpectedDeliveryDate() {
		return expectedDeliveryDate;
	}

	public void setExpectedDeliveryDate(DateFormat expectedDeliveryDate) {
		this.expectedDeliveryDate = expectedDeliveryDate;
	}
	@ManyToOne
	@JoinColumn(name="cNumber", referencedColumnName="cNumber")
	public Customer getCustomer() {
		return customer;
	}

	public void setCustomer(Customer customer) {
		this.customer = customer;
	}
    @OneToMany(mappedBy="order")
	public Set<Orderspecification> getOrderspecification() {
		return orderspecification;
	}

	public void setOrderspecification(Set<Orderspecification> orderspecification) {
		this.orderspecification = orderspecification;
	}

	

}
