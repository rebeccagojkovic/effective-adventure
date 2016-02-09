package entity.ejb;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "Orderspecification")
public class Orderspecification {
	private String oNumber;
	private String pNumber;
	private Order order;
	private Product product;

	@Id
	@Column(name="oNumber")
	public String getoNumber() {
		return oNumber;
	}

	public void setoNumber(String oNumber) {
		this.oNumber = oNumber;
	}
	@Id
	@Column(name="pNumber")
	public String getpNumber() {
		return pNumber;
	}

	public void setpNumber(String pNumber) {
		this.pNumber = pNumber;
	}

	public Order getOrder() {
		return order;
	}

	public void setOrder(Order order) {
		this.order = order;
	}

	public Product getProduct() {
		return product;
	}

	public void setProduct(Product product) {
		this.product = product;
	}
	

}