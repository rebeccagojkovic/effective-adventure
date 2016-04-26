package entity.ejb;

import java.io.Serializable;
import java.sql.Timestamp;
import java.util.Set;


import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@NamedQueries({ @NamedQuery(name = "Order.findAllOrders", query = "SELECT o FROM Order o"),
		@NamedQuery(name = "Order.findCertainOrder", query = "SELECT o FROM Order o WHERE o.oNumber LIKE :customer"),
		@NamedQuery(name = "Order.isDelivered", query = "SELECT o FROM Order o WHERE o.isDelivered LIKE :isDelivered"),
		//@NamedQuery(name = "Order.updateOrder", query = "SELECT o FROM Order o WHERE o.oNumber LIKE :updateOrder")
		})
@Table(name = "Orde")
public class Order implements Serializable {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
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
	public boolean getisDelivered() {
		return isDelivered;
	}

	public void setisDelivered(boolean isDelivered) {
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
	@JoinColumn(name = "cNumber_FK", referencedColumnName = "cNumber")
	public Customer getCustomer() {
		return customer;
	}

	public void setCustomer(Customer customer) {
		this.customer = customer;
	}

	@OneToMany(mappedBy = "order", fetch = FetchType.EAGER)
	public Set<Orderspecification> getOrderspecification() {
		return orderspecification;
	}

	public void setOrderspecification(Set<Orderspecification> orderspecification) {
		this.orderspecification = orderspecification;
	}

}
