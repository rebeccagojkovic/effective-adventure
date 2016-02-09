package entity.ejb;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.JoinTable;
import javax.persistence.ManyToMany;
import javax.persistence.OneToMany;
import javax.persistence.Table;

@Entity
@Table(name = "Ingredient")
public class Ingredient {
	private String iNumber;
	private String iName;
	private int iQuantityInStock;
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
	public int getiQuantityInStock() {
		return iQuantityInStock;
	}

	public void setiQuantityInStock(int iQuantityInStock) {
		this.iQuantityInStock = iQuantityInStock;
	}
	
	@OneToMany(mappedBy="ingredient")
	public Set<Recipe> getRecipe() {
		return recipe;
	}

	public void setRecipe(Set<Recipe> recipe) {
		this.recipe = recipe;
	}

	

	

}
