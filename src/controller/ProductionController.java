package controller;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ComponentEvent;
import java.awt.event.ComponentListener;
import model.Database;
import model.IngredientBoolean;

import view.KrustyGUI;

public class ProductionController {

    private KrustyGUI gui;
    private Database db;
    private SimulationController simCtrl;

    public ProductionController(KrustyGUI gui, Database db, SimulationController simCtrl) {
        this.gui = gui;
        this.db = db;

        gui.produceStatusLabel.setText("Connecting to database ...");

        if (db.openConnection("db46", "gkz100kr")) {
            this.gui.produceStatusLabel.setText("Connected to database");
        } else {
            this.gui.produceStatusLabel.setText("Could not connect to database");
        }
        this.simCtrl = simCtrl;

        this.gui.produceButton.addActionListener(new ProduceButtonListener());
        this.gui.nbrPalletsField.addActionListener(new ProduceButtonListener());
        this.gui.producePane.addComponentListener(new ProducePaneListener());

        this.populateCookieBox();
        new WindowController(gui, db);
    }

    private void populateCookieBox() {
        gui.cookieBox.setModel(db.getProducts());
    }

    class ProduceButtonListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            String pName = (String) gui.cookieBox.getSelectedItem();
            int nbrPallets = 0;

            try {
                nbrPallets = Integer.parseInt(gui.nbrPalletsField.getText().trim());
            } catch (Exception pe) {
                gui.nbrPalletsField.setText("");
            }

            IngredientBoolean ib = db.canHasInventory(nbrPallets, pName);

            if (ib.yesWeCan) {
                if (nbrPallets > 0) {
                    simCtrl.produceCookies(pName, nbrPallets);
                    gui.produceStatusLabel.setText(nbrPallets + " pallets of " + pName + " ordered");
                }
            } else {
                gui.produceStatusLabel.setText("Not enough " + ib.iName + ", need " + ib.amount + " " + ib.unit + ", but only have " + ib.totalAmount + " " + ib.unit + ". HA HA!");
            }
        }
    }

    class ProducePaneListener implements ComponentListener {

        @Override
        public void componentHidden(ComponentEvent e) {
        }

        @Override
        public void componentMoved(ComponentEvent e) {
        }

        @Override
        public void componentResized(ComponentEvent e) {
        }

        @Override
        public void componentShown(ComponentEvent e) {
            populateCookieBox();
        }
    }
}
