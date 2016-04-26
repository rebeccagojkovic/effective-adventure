package entityAccess.eao;

import javax.ejb.Stateless;
import javax.persistence.EntityManager;
import javax.persistence.PersistenceContext;
import javax.persistence.TypedQuery;

import java.sql.Timestamp;
import java.util.List;

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
	}

	@Override
	public Product findBypNumber(String pNumber) {
		return em.find(Product.class, pNumber);

	}

	@Override
	public Product createProduct(Product product) {
		em.persist(product);
		return product;
	}

	@Override
	public Product updateProduct(Product product) {
		em.merge(product);
		return product;
	}

	@Override
	public void deleteProduct(String pNumber) {
		Product p = this.findBypNumber(pNumber);
		if (p != null) {
			em.remove(p);
		}
	}

	@Override
	public List<Product> findAllProducts() {
		TypedQuery<Product> query = em.createNamedQuery("Product.findAllProducts", Product.class);
		List<Product> results = query.getResultList();
		return results;
	}

	@Override
	public List<Product> InfoTimeStamp(Timestamp pTime) {
		TypedQuery<Product> query = em.createNamedQuery("Product.InfoTimeStamp", Product.class);
		query.setParameter("pTime", pTime);
		List<Product> results = query.getResultList();
		return results;
	}

	@Override
	public List<Product> findBypName(String pName) {
		TypedQuery<Product> query = em.createNamedQuery("Product.findBypName", Product.class);
		query.setParameter("pName", pName);
		List<Product> results = query.getResultList();
		return results;
	}
}
