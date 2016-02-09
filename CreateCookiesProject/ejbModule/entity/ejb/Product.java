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
	private String pNumber;
	private String pName;
	private  DateFormat pTime;
	private Set<Recipe> recipe;
	private Set<Orderspecification> orderspecification;

	@Column(name="pNumber")
	public String getpNumber() {
		return pNumber;
	}

	public void setpNumber(String pNumber) {
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
	
	

	public Set<Recipe> getRecipe() {
		return recipe;
	}

	public void setRecipe(Set<Recipe> recipe) {
		this.recipe = recipe;
	}

	public Set<Orderspecification> getOrderspecification() {
		return orderspecification;
	}

	public void setOrderspecification(Set<Orderspecification> orderspecification) {
		this.orderspecification = orderspecification;
	}
  

}
