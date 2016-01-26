package controller;

import java.util.Observable;
import java.util.Observer;
import model.Database;
import model.InventoryStorageModel;
import view.KrustyGUI;

public class InventoryController implements Observer {

    KrustyGUI gui;
    Database db;
    InventoryStorageModel ism;

    public InventoryController(Database db, KrustyGUI gui) {
        this.db = db;
        this.gui = gui;
        ism = new InventoryStorageModel(db);
        this.gui.inventoryTable.setModel(ism);
        this.db.addObserver(this);
    }

    @Override
    public void update(Observable o, Object o1) {
        ism.updateInventory();
    }
}
