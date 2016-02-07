package entityAccess.eao;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;

import entity.ejb.Product;

/**
 * Session Bean implementation class ProductEAOImpl
 */
@Stateless
public class ProductEAOImpl implements ProductEAOImplLocal {

	@PersistenceContext(unitName = "LabEJBSQL")
	private EntityManager em;

	/**
	 * Default constructor.
	 */
	public ProductEAOImpl() {
		// TODO Auto-generated constructor stub
	}

	public Product findBypNumber(int pNumber) {
		return em.find(Product.class, pNumber);

	}

	public Product createProduct(Product product) {
		em.persist(product);
		return product;
	}

	public Product updateProduct(Product product) {
		em.merge(product);
		return product;
	}

	public void deleteProduct(int pNumber) {
		Product p = this.findBypNumber(pNumber);
		if (p != null) {
			em.remove(p);
		}
	}

}
