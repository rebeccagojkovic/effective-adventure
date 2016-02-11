package entity.ejb;

import java.sql.Timestamp;
import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name = "Product")
public class Product {
	private String pNumber;
	private String pName;
	private Timestamp pTime;
	private Set<Recipe> recipe;
	private Set<Orderspecification> orderspecification;

	@Id
	@Column(name = "pNumber")
	public String getpNumber() {
		return pNumber;
	}

	public void setpNumber(String pNumber) {
		this.pNumber = pNumber;
	}

	@Column(name = "pName")
	public String getpName() {
		return pName;
	}

	public void setpName(String pName) {
		this.pName = pName;
	}

	@Column(name = "pTime")
	public Timestamp getpTime() {
		return pTime;
	}

	public void setpTime(Timestamp pTime) {
		this.pTime = pTime;
	}

	@OneToMany(mappedBy = "product")
	public Set<Recipe> getRecipe() {
		return recipe;
	}

	public void setRecipe(Set<Recipe> recipe) {
		this.recipe = recipe;
	}

	@OneToMany(mappedBy = "product")
	public Set<Orderspecification> getOrderspecification() {
		return orderspecification;
	}

	public void setOrderspecification(Set<Orderspecification> orderspecification) {
		this.orderspecification = orderspecification;
	}

}
