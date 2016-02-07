package entity.ejb;

import java.text.DateFormat;
import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.ManyToMany;
import javax.persistence.Table;

@Entity
@Table(name="Product")
public class Product {
	private int pNumber;
	private String pName;
	private  DateFormat pTime;
	private Set<Ingredient> ingredients;
	private Set<Order> orders;

	@Column(name="pNumber")
	public int getpNumber() {
		return pNumber;
	}

	public void setpNumber(int pNumber) {
		this.pNumber = pNumber;
	}
	@Column(name="pName")
	public String getpName() {
		return pName;
	}

	public void setpName(String pName) {
		this.pName = pName;
	}
	@Column(name="pTime")
	public DateFormat getpTime() {
		return pTime;
	}

	public void setpTime(DateFormat pTime) {
		this.pTime = pTime;
	}
    @ManyToMany(mappedBy="products")
	public Set<Ingredient> getIngredients() {
		return ingredients;
	}

	public void setIngredients(Set<Ingredient> ingredients) {
		this.ingredients = ingredients;
	}
	@ManyToMany(mappedBy="products")
	public Set<Order> getOrders() {
		return orders;
	}

	public void setOrders(Set<Order> orders) {
		this.orders = orders;
	}

}
