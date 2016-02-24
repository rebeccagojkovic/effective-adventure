package entity.ejb;

import java.io.Serializable;

import javax.persistence.Column;
import javax.persistence.Embeddable;

@Embeddable
public class RecipeId implements Serializable {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private String pNumber;
	private String iNumber;

	public RecipeId() {

	}

	public RecipeId(String pNumber, String iNumber) {
		this.pNumber = pNumber;
		this.iNumber = iNumber;
	}

	@Column(name = "pNumber", nullable = false)
	public String getpNumber() {
		return pNumber;
	}

	public void setpNumber(String pNumber) {
		this.pNumber = pNumber;

	}

	@Column(name = "iNumber", nullable = false)
	public String getiNumber() {
		return iNumber;

	}

	public void setiNumber(String iNumber) {
		this.iNumber = iNumber;
	}

	@Override
	public boolean equals(Object other) {
		if ((this == other)) {
			return true;
		}

		if ((other == null)) {
			return false;
		}
		if (!(other instanceof RecipeId)) {
			return false;
		}

		RecipeId castOther = (RecipeId) other;

		return ((this.getpNumber() == castOther.getpNumber()) || (this.getpNumber() != null
				&& castOther.getpNumber() != null && this.getpNumber().equals(castOther.getpNumber())))
				&& ((this.getiNumber() == castOther.getiNumber()) || (this.getiNumber() != null
						&& castOther.getiNumber() != null && this.getiNumber().equals(castOther.getiNumber())));
	}

	@Override
	public int hashCode() {
		return super.hashCode();

	}

}
