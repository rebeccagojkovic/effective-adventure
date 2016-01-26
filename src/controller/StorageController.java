package controller;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ComponentEvent;
import java.awt.event.ComponentListener;
import java.awt.event.FocusEvent;
import java.awt.event.FocusListener;
import java.util.ArrayList;
import javax.swing.JTextField;

import model.Database;
import model.StorageModel;

import view.KrustyGUI;

public class StorageController {

    private KrustyGUI gui;
    private Database db;
    private StorageModel sm;

    public StorageController(KrustyGUI gui, Database db, StorageModel sm) {
        this.gui = gui;
        this.db = db;
        this.sm = sm;
        this.gui.storageTable.setModel(sm);

        this.gui.filterButton.addActionListener(new filterButtonListener());
        this.gui.blockButton.addActionListener(new BlockButtonListener());
        this.gui.unblockButton.addActionListener(new UnBlockButtonListener());
        this.gui.clearButton.addActionListener(new clearButtonListener());
        this.gui.searchToTimestampField.addActionListener(new filterButtonListener());
        this.gui.storagePane.addComponentListener(new StoragePaneListener());
        this.gui.searchFromTimestampField.addFocusListener(new searchTimestampFieldListener());
        this.gui.searchToTimestampField.addFocusListener(new searchTimestampFieldListener());
        this.gui.showPalletLabel.addActionListener(new showPalletButtonListener());
        this.gui.showPalletButton.addActionListener(new showPalletButtonListener());

        this.populateSearchCookieBox();
        this.update(db.getPalletsInStorage());
    }

    private void populateSearchCookieBox() {
        gui.searchCookieBox.setModel(db.getProductsInStorage());
    }

    private void update(StorageModel newModel) {
        sm = newModel;
        gui.storageTable.setModel(sm);
        int rows = sm.getRowCount();
        if (rows == 0) {
            gui.statusLabel.setText("No pallets found");
        } else {
            gui.statusLabel.setText(rows + " pallet(s) found");
        }
    }

    private ArrayList<Integer> selectedPallets() {
        int selectedRows[] = gui.storageTable.getSelectedRows();
        ArrayList<Integer> idList = new ArrayList<Integer>();

        for (int i = 0; i < selectedRows.length; i++) {
            idList.add((Integer) (gui.storageTable.getValueAt(selectedRows[i], 0)));
        }
        return idList;
    }

    private boolean toggleBlock(boolean status) {
        ArrayList<Integer> toBlock = selectedPallets();
        int n = toBlock.size();
        boolean execStatus = false;

        for (int i = 0; i < n; i++) {
            execStatus = db.toggleBlock(status, toBlock.get(i));
        }
        update(db.getPalletsFromIdNbr(sm.allShownPallets()));
        return execStatus;
    }

    class filterButtonListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            String searchPName = (String) gui.searchCookieBox.getSelectedItem();
            String searchFromTimestamp = gui.searchFromTimestampField.getText();
            String searchToTimestamp = gui.searchToTimestampField.getText();

            StorageModel searchModel;
            if (searchFromTimestamp.equals("yyyy-mm-dd") && searchToTimestamp.equals("yyyy-mm-dd")) {
                searchModel = db.searchProductName(searchPName);
            } else {
                searchModel = db.search(searchPName, searchFromTimestamp, searchToTimestamp);
            }

            if (searchModel == null) {
                update(new StorageModel());
            } else {
                update(searchModel);
            }
        }
    }

    class BlockButtonListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            if (toggleBlock(true)) {
                gui.statusLabel.setText("Pallets blocked");
            } else {
                gui.statusLabel.setText("Unable to block pallets");
            }
        }
    }

    class UnBlockButtonListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            if (toggleBlock(false)) {
                gui.statusLabel.setText("Pallets unblocked");
            } else {
                gui.statusLabel.setText("Unable to unblock pallets");
            }
        }
    }

    class clearButtonListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            update(db.getPalletsInStorage());
            gui.searchFromTimestampField.setText("yyyy-mm-dd");
            gui.searchToTimestampField.setText("yyyy-mm-dd");
        }
    }

    class searchTimestampFieldListener implements FocusListener {

        @Override
        public void focusGained(FocusEvent e) {
            if (((JTextField) e.getComponent()).getText().equals("yyyy-mm-dd")) {
                ((JTextField) e.getComponent()).setText("");
            }
        }

        @Override
        public void focusLost(FocusEvent e) {
            if (((JTextField) e.getComponent()).getText().trim().equals("")) {
                ((JTextField) e.getComponent()).setText("yyyy-mm-dd");
            }
        }
    }

    class showPalletButtonListener implements ActionListener {

        @Override
        public void actionPerformed(ActionEvent e) {
            int pid = 0;
            String str = gui.showPalletLabel.getText().trim();
            try {
                pid = Integer.parseInt(str);
                StorageModel searchModel = db.searchPID(pid);
                if (searchModel == null) {
                    update(new StorageModel());
                    gui.statusLabel.setText("Pallet " + pid + " not found");
                } else {
                    update(searchModel);
                }

            } catch (NumberFormatException nfe) {
                gui.statusLabel.setText("'" + str + "' is not a valid pallet ID");
            }
        }
    }

    class StoragePaneListener implements ComponentListener {

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
            update(sm);
        }
    }
}
