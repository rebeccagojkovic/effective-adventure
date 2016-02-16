package entityAccess.eao;

import javax.ejb.Local;

import entity.ejb.Product;

@Local
public interface ProductEAOImplLocal {
	public Product findBypNumber(String pNumber);

	public Product createProduct(Product product);

	public Product updateProduct(Product product);

	public void deleteProduct(String pNumber);
}
