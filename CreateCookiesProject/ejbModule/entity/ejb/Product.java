package entity.ejb;

import java.io.Serializable;
import java.sql.Timestamp;
import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@NamedQueries({
@NamedQuery(name= "Product.findAllProducts", query= "SELECT p FROM Product p"),
@NamedQuery(name= "Product.InfoTimeStamp", query= "SELECT p.pName, p.pTime FROM Product p WHERE p.pNumber LIKE :pNumber"),
})


@Table(name = "Product")
public class Product implements Serializable {
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

	@OneToMany(mappedBy = "product", fetch=FetchType.EAGER)
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
