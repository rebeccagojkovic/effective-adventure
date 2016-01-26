package model;

public class IngredientBoolean {

    public String iName;
    public boolean yesWeCan;
    public int amount;
    public int totalAmount;
    public String unit;

    public IngredientBoolean(String iName, boolean yesWeCan, int amount, int totalAmount, String unit) {
        this.iName = iName;
        this.yesWeCan = yesWeCan;
        this.amount = amount;
        this.totalAmount = totalAmount;
        this.unit = unit;
    }
}
