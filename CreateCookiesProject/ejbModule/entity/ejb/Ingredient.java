package entity.ejb;

import java.io.Serializable;
import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.FetchType;
import javax.persistence.Id;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name = "Ingredient")
public class Ingredient implements Serializable{
	private String iNumber;
	private String iName;
	private double iQuantityInStock;
	private Set<Recipe> recipe;

	@Id
	@Column(name = "iNumber")
	public String getiNumber() {
		return iNumber;
	}

	public void setiNumber(String iNumber) {
		this.iNumber = iNumber;
	}

	@Column(name = "iName")
	public String getiName() {
		return iName;
	}

	public void setiName(String iName) {
		this.iName = iName;
	}

	@Column(name = "iQuantityInStock")
	public double getiQuantityInStock() {
		return iQuantityInStock;
	}

	public void setiQuantityInStock(double iQuantityInStock) {
		this.iQuantityInStock = iQuantityInStock;
	}
	
	@OneToMany(mappedBy="ingredient", fetch=FetchType.EAGER)
	public Set<Recipe> getRecipe() {
		return recipe;
	}

	public void setRecipe(Set<Recipe> recipe) {
		this.recipe = recipe;
	}

	

	

}
