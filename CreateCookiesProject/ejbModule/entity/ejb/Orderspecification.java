package entity.ejb;

import javax.persistence.Column;
import javax.persistence.EmbeddedId;
import javax.persistence.Entity;

import javax.persistence.JoinColumn;
import javax.persistence.JoinColumns;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "Orderspecification")
public class Orderspecification {
	
	private OrderspecificationId pNumberONumber;
	private Order order;
	private Product product;

	@EmbeddedId
	public OrderspecificationId getpNumberONumber() {
		return pNumberONumber;
	}

	public void setpNumberONumber(OrderspecificationId pNumberONumber) {
		this.pNumberONumber = pNumberONumber;
	}

	@ManyToOne
	@JoinColumn(name = "oNumber_FK", referencedColumnName = "oNumber")
//	@JoinColumns({ @JoinColumn(name = "pNumber_FK", referencedColumnName = "oNumber"),
//			@JoinColumn(name = "oNumber_FK", referencedColumnName = "oNumber") })
	public Order getOrder() {
		return order;
	}

	public void setOrder(Order order) {
		this.order = order;
	}
	@ManyToOne
	@JoinColumn(name = "pNumber_FK", referencedColumnName = "pNumber")
//	@JoinColumns({ @JoinColumn(name = "iNumber_FK", referencedColumnName = "pNumber"),
//			@JoinColumn(name = "pNumber_FK", referencedColumnName = "pNumber") })
	public Product getProduct() {
		return product;
	}
	
	public void setProduct(Product product) {
		this.product = product;
	}
	

}