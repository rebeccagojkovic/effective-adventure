package model;

import java.util.ArrayList;
import javax.swing.table.AbstractTableModel;

public class InventoryStorageModel extends AbstractTableModel {

    Database db;
    String col[] = {"Ingredient", "Total Amount", "Latest Delivery amount", "Latest Delivery Date"};
    ArrayList<Inventory> inventory;

    public InventoryStorageModel(Database db) {
        this.db = db;
        this.inventory = this.db.getInventory();
    }

    public void updateInventory() {
        inventory = db.getInventory();
        fireTableDataChanged();

    }

    @Override
    public int getRowCount() {
        return inventory.size();
    }

    @Override
    public int getColumnCount() {
        return 4;
    }

    @Override
    synchronized public String getColumnName(int column) {
        if (column < 4) {
            return col[column];
        } else {
            return "yea yea yea " + column;
        }
    }

    @Override
    public Object getValueAt(int index, int column) {
        Inventory iv = inventory.get(index);
        switch (column) {
            case 0:
                return iv.iName;
            case 1:
                return iv.totalAmount;
            case 2:
                return iv.latestDeliveryAmount;
            case 3:
                return iv.latestDeliveryDate;
            default:
                return "you can't has this! du du du duuh";
        }
    }
}
