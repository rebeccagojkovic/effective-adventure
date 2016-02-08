package entity.ejb;

import java.io.Serializable;

import javax.persistence.Column;



public class RecipeId {
	
	private int pNumber;
	private int iNumber;
	
	public RecipeId() {
		
	}
	
	public RecipeId(int pNumber, long iNumber) {
		this.pNumber = pNumber;
		this.iNumber = iNumber;
	}
	
	@Column(name = "pNumber", nullable = false)
	public int getpNumber() {
		return pNumber;
	}

	public void setpNumber(int pNumber) {
		this.pNumber = pNumber;

	}

	@Column(name = "iNumber", nullable = false)
	public long getiNumber() {
		return iNumber;

	}

	public void setiNumber(long iNumber) {
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

		return ((this.getpNumber() == castOther.getpNumber()) || (this.getpNumber() != null && castOther.getpNumber() != null
				&& this.getpNumber().equals(castOther.getpNumber())))
				&& ((this.getiNumber() == castOther.getiNumber()) || (this.getiNumber() != null
						&& castOther.getiNumber() != null && this.getiNumber().equals(castOther.getiNumber())));
	}

	@Override
	public int hashCode() {
		return super.hashCode();

	}

}
