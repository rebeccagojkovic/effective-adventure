package entity.ejb;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.EmbeddedId;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "Orderspecification")
public class Orderspecification {
	
	private String pNumberONumber;
	private Order order;
	private Product product;

	@EmbeddedId
	public String getpNumberONumber() {
		return pNumberONumber;
	}

	public void setpNumberONumber(String pNumberONumber) {
		this.pNumberONumber = pNumberONumber;
	}

	@ManyToOne
	@JoinColumn(name="pNumberONumber", referencedColumnName="oNumber")
	public Order getOrder() {
		return order;
	}

	public void setOrder(Order order) {
		this.order = order;
	}
	@ManyToOne
	@JoinColumn(name="pNumberONumber", referencedColumnName="pNumber")
	public Product getProduct() {
		return product;
	}
	
	public void setProduct(Product product) {
		this.product = product;
	}
	

}