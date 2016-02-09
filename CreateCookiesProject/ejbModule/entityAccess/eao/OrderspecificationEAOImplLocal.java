package entityAccess.eao;

import javax.ejb.Local;

import entity.ejb.Orderspecification;
import entity.ejb.Recipe;

@Local
public interface OrderspecificationEAOImplLocal {
	public Orderspecification findBypNumberONumber(String pNumber, String oNumber);

	public Orderspecification createOrderspecification(
			Orderspecification orderspecification);

	public Orderspecification updateOrderspecification(
			Orderspecification orderspecification);

	public void deleteOrderspecification(String pNumber, String oNumber);
}
