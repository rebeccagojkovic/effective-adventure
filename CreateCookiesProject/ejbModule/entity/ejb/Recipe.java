package entity.ejb;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.EmbeddedId;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.JoinColumns;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "Recipe")
public class Recipe {

	private String iNumberPNumber;
	private int quantity;
	private Ingredient ingredient;
	private Product product;

	@EmbeddedId
	public String getiNumberPNumber() {
		return iNumberPNumber;
	}

	public void setiNumberPNumber(String iNumberPNumber) {
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
	@JoinColumns({ @JoinColumn(name = "iNumber", referencedColumnName = "iNumber"),
			@JoinColumn(name = "pNumber", referencedColumnName = "iNumber") })
	public Ingredient getIngredient() {
		return ingredient;
	}

	public void setIngredient(Ingredient ingredient) {
		this.ingredient = ingredient;
	}

	@ManyToOne
	@JoinColumns({ @JoinColumn(name = "iNumber", referencedColumnName = "pNumber"),
			@JoinColumn(name = "pNumber", referencedColumnName = "pNumber") })
	public Product getProduct() {
		return product;
	}

	public void setProduct(Product product) {
		this.product = product;
	}

}
