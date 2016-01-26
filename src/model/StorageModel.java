package model;

import java.util.ArrayList;
import javax.swing.table.AbstractTableModel;

@SuppressWarnings("serial")
public class StorageModel extends AbstractTableModel {

    String col[] = {"Pallet ID", "Product", "Timestamp", "Blocked"};
    private ArrayList<Pallet> pallets;

    public StorageModel() {
        this.pallets = new ArrayList<Pallet>();
        this.fireTableDataChanged();
    }

    synchronized public void addPallet(int idNbr, String pName, String timestamp, boolean isBlocked) {
        this.pallets.add(new Pallet(idNbr, pName, timestamp, isBlocked));
        this.fireTableDataChanged();
    }

    @Override
    synchronized public String getColumnName(int column) {
        if (column < 4) {
            return col[column];
        } else {
            return "Filed " + column;
        }
    }

    @Override
    synchronized public int getColumnCount() {
        return 4;
    }

    @Override
    synchronized public int getRowCount() {
        return this.pallets.size();
    }

    @Override
    synchronized public Object getValueAt(int rowIndex, int columnIndex) {
        Pallet pallet = this.pallets.get(rowIndex);
        if (columnIndex == 0) {
            return pallet.getIdNbr();
        } else if (columnIndex == 1) {
            return pallet.getPName();
        } else if (columnIndex == 2) {
            return pallet.getTimeStamp();
        } else {
            return pallet.getIsBlocked();
        }
    }

    synchronized public ArrayList<Integer> allShownPallets() {
        ArrayList<Integer> ret = new ArrayList<Integer>();
        for (Pallet p : this.pallets) {
            ret.add(p.getIdNbr());
        }
        return ret;
    }
}
