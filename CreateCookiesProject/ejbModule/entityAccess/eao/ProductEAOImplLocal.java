package entityAccess.eao;

import java.sql.Timestamp;
import java.util.List;

import javax.ejb.Local;

import entity.ejb.Product;

@Local
public interface ProductEAOImplLocal {
	public Product findBypNumber(String pNumber);

	public Product createProduct(Product product);

	public Product updateProduct(Product product);

	public void deleteProduct(String pNumber);

	public List<Product> findAllProducts();

	public List<Product> InfoTimeStamp(Timestamp pTime);

	public List<Product> findBypName(String pName);
}
