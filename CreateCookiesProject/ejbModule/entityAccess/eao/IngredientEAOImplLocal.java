package entityAccess.eao;

import javax.ejb.Local;

import entity.ejb.Ingredient;

@Local
public interface IngredientEAOImplLocal {
	public Ingredient findByiNumber(int iNumber);

	public Ingredient createIngredient(Ingredient ingredient);

	public Ingredient updateIngredient(Ingredient ingredient);

	public void deleteIngredient(int iNumber);

}
