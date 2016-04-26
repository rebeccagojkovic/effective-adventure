package entity.ejb;

import java.io.Serializable;

import javax.persistence.Column;
import javax.persistence.EmbeddedId;
import javax.persistence.Entity;

import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "Orderspecification")
public class Orderspecification implements Serializable {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private OrderspecificationId pNumberONumber;
	private int palletQuantity;
	private Order order;
	private Product product;

	@EmbeddedId
	public OrderspecificationId getpNumberONumber() {
		return pNumberONumber;
	}

	public void setpNumberONumber(OrderspecificationId pNumberONumber) {
		this.pNumberONumber = pNumberONumber;
	}

	@Column(name = "palletQuantity")
	public int getPalletQuantity() {
		return palletQuantity;
	}

	public void setPalletQuantity(int palletQuantity) {
		this.palletQuantity = palletQuantity;
	}

	@ManyToOne
	@JoinColumn(name = "oNumber_FK", referencedColumnName = "oNumber")
	// @JoinColumns({ @JoinColumn(name = "pNumber_FK", referencedColumnName =
	// "oNumber"),
	// @JoinColumn(name = "oNumber_FK", referencedColumnName = "oNumber") })
	public Order getOrder() {
		return order;
	}

	public void setOrder(Order order) {
		this.order = order;
	}

	@ManyToOne
	@JoinColumn(name = "pNumber_FK", referencedColumnName = "pNumber")
	// @JoinColumns({ @JoinColumn(name = "iNumber_FK", referencedColumnName =
	// "pNumber"),
	// @JoinColumn(name = "pNumber_FK", referencedColumnName = "pNumber") })
	public Product getProduct() {
		return product;
	}

	public void setProduct(Product product) {
		this.product = product;
	}

}