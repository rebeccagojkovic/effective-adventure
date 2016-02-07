package entity.ejb;

import java.util.Set;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.JoinTable;
import javax.persistence.ManyToMany;
import javax.persistence.Table;

@Entity
@Table(name = "Ingredient")
public class Ingredient {
	private int iNumber;
	private String iName;
	private int iQuantityInStock;
	private Set<Product> products;

	@Id
	@Column(name = "iNumber")
	public int getiNumber() {
		return iNumber;
	}

	public void setiNumber(int iNumber) {
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

	@ManyToMany
	@JoinTable(name = "Recipe", joinColumns = @JoinColumn(name = "iNumber", referencedColumnName = "iNumber"), inverseJoinColumns = @JoinColumn(name = "pNumber", referencedColumnName = "pNumber"))
	public Set<Product> getProducts() {
		return products;
	}

	public void setProducts(Set<Product> products) {
		this.products = products;
	}

}
