package entity.ejb;

import java.sql.Timestamp;
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
@Table(name = "Orde")
public class Order {
	private String oNumber;
	private boolean isDelivered;
	private Timestamp expectedDeliveryDate;
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
	public Timestamp getExpectedDeliveryDate() {
		return expectedDeliveryDate;
	}

	public void setExpectedDeliveryDate(Timestamp expectedDeliveryDate) {
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
