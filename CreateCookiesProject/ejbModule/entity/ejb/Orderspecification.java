package entity.ejb;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "Orderspecification")
public class Orderspecification {
	private long oNumber;
	private int pNumber;
	private Set<Order> orders;
	private Set<Product> products;

	@Id
	@Column(name="oNumber")
	public long getoNumber() {
		return oNumber;
	}

	public void setoNumber(long oNumber) {
		this.oNumber = oNumber;
	}
	@Id
	@Column(name="pNumber")
	public int getpNumber() {
		return pNumber;
	}

	public void setpNumber(int pNumber) {
		this.pNumber = pNumber;
	}

	public Set<Order> getOrders() {
		return orders;
	}

	public void setOrders(Set<Order> orders) {
		this.orders = orders;
	}

	public Set<Product> getProducts() {
		return products;
	}

	public void setProducts(Set<Product> products) {
		this.products = products;
	}

}