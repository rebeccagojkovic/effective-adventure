package entity.ejb;

import javax.persistence.Column;
import javax.persistence.EmbeddedId;
import javax.persistence.Entity;
import javax.persistence.JoinColumn;
import javax.persistence.JoinColumns;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "Recipe")
public class Recipe {

	private RecipeId iNumberPNumber;
	private int quantity;
	private Ingredient ingredient;
	private Product product;

	@EmbeddedId
	public RecipeId getiNumberPNumber() {
		return iNumberPNumber;
	}

	public void setiNumberPNumber(RecipeId iNumberPNumber) {
		this.iNumberPNumber = iNumberPNumber;
	}

	@Column(name = "quantity")
	public int getQuantity() {
		return quantity;
	}

	public void setQuantity(int quantity) {
		this.quantity = quantity;
	}

	@ManyToOne
	@JoinColumns({ @JoinColumn(name = "iNumber", referencedColumnName = "iNumber", insertable = false, updatable = false),
			@JoinColumn(name = "pNumber", referencedColumnName = "iNumber", insertable = false, updatable = false) })
	public Ingredient getIngredient() {
		return ingredient;
	}

	public void setIngredient(Ingredient ingredient) {
		this.ingredient = ingredient;
	}

	@ManyToOne
	@JoinColumns({ @JoinColumn(name = "iNumber", referencedColumnName = "pNumber", insertable = false, updatable = false),
			@JoinColumn(name = "pNumber", referencedColumnName = "pNumber", insertable = false, updatable = false) })
	public Product getProduct() {
		return product;
	}

	public void setProduct(Product product) {
		this.product = product;
	}

}
