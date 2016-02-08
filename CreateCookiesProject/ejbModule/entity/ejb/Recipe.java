package entity.ejb;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "Recipe")
public class Recipe {
	private long pNumber;
	private long iNumber;
	private Set<Ingredient> Ingredients;
	private Set<Product> products;

	@Id
	@Column(name = "pNumber")
	public long getpNumber() {
		return pNumber;
	}

	public void setpNumber(int pNumber) {
		this.pNumber = pNumber;
	}

	@Id
	@Column(name = "iNumber")
	public long getiNumber() {
		return iNumber;
	}

	public void setiNumber(int iNumber) {
		this.iNumber = iNumber;
	}

	public Set<Ingredient> getIngredients() {
		return Ingredients;
	}

	public void setIngredients(Set<Ingredient> ingredients) {
		Ingredients = ingredients;
	}

	public Set<Product> getProducts() {
		return products;
	}

	public void setProducts(Set<Product> products) {
		this.products = products;
	}

}
