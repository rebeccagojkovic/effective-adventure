package entityAccess.eao;

import javax.ejb.Local;
import java.util.List;
import entity.ejb.Ingredient;

@Local
public interface IngredientEAOImplLocal {
	public Ingredient findByiNumber(String iNumber);

	public Ingredient createIngredient(Ingredient ingredient);

	public Ingredient updateIngredient(Ingredient ingredient);

	public void deleteIngredient(String iNumber);
	
	public List <Ingredient> findAllIngredients();
	
	public List<Ingredient> findByName(String iName);

}
