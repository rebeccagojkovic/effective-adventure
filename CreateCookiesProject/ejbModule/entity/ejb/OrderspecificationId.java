package entity.ejb;

import java.io.Serializable;

import javax.persistence.Column;
import javax.persistence.Embeddable;


@Embeddable
public class OrderspecificationId {
	
	private int pNumber;
	private long oNumber;
	
	public OrderspecificationId() {
		
	}
	
	public OrderspecificationId(int pNumber, long oNumber) {
		this.pNumber = pNumber;
		this.oNumber = oNumber;
	}
	
	@Column(name = "pNumber", nullable = false)
	public int getpNumber() {
		return pNumber;
	}

	public void setpNumber(int pNumber) {
		this.pNumber = pNumber;

	}

	@Column(name = "oNumber", nullable = false)
	public long getoNumber() {
		return oNumber;

	}

	public void setoNumber(long oNumber) {
		this.oNumber = oNumber;
	}

	@Override
	public boolean equals(Object other) {
		if ((this == other)) {
			return true;
		}

		if ((other == null)) {
			return false;
		}
		if (!(other instanceof OrderspecificationId)) {
			return false;
		}

		OrderspecificationId castOther = (OrderspecificationId) other;

		return ((this.getpNumber() == castOther.getpNumber()) || (this.getpNumber() != null && castOther.getpNumber() != null
				&& this.getpNumber().equals(castOther.getpNumber())))
				&& ((this.getoNumber() == castOther.getoNumber()) || (this.getoNumber() != null
						&& castOther.getoNumber() != null && this.getoNumber().equals(castOther.getoNumber())));
	}

	@Override
	public int hashCode() {
		return super.hashCode();

	}

}
