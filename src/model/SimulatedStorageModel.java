package model;

import java.util.ArrayList;
import javax.swing.table.AbstractTableModel;

@SuppressWarnings("serial")
public class SimulatedStorageModel extends AbstractTableModel {

    private String modelString;
    String col[] = {"Product", "# Pallets", "% Progress"};
    private ArrayList<SimulatedBatch> batches;

    public SimulatedStorageModel() {
        this.batches = new ArrayList<SimulatedBatch>();
    }

    synchronized public void addSimulatedBatch(SimulatedBatch sb) {
        this.batches.add(sb);
        this.fireTableDataChanged();
    }

    @SuppressWarnings("unchecked")
    synchronized public ArrayList<SimulatedBatch> getSimulatedBatches() {
        return (ArrayList<SimulatedBatch>) batches.clone();
    }

    synchronized public void removeBatch(SimulatedBatch sb) {
        int sbidx = this.batches.indexOf(sb);
        if (sbidx < 0) {
            System.out.println("simulated batch not found: " + sb);
            return;
        }
        this.batches.remove(sbidx);
        this.fireTableDataChanged();
    }

    synchronized public String getModelString() {
        return this.modelString;
    }

    synchronized public void setModelString(String iModelString) {
        this.modelString = iModelString;
    }

    @Override
    synchronized public String getColumnName(int column) {
        if (column < 3) {
            return col[column];
        } else {
            return "Filed " + column;
        }
    }

    @Override
    synchronized public int getColumnCount() {
        return 3;
    }

    @Override
    synchronized public int getRowCount() {
        return this.batches.size();
    }

    @Override
    synchronized public Object getValueAt(int rowIndex, int columnIndex) {
        SimulatedBatch batch = this.batches.get(rowIndex);
        if (columnIndex == 0) {
            return batch.getPName();
        } else if (columnIndex == 1) {
            return batch.getNbrPallets();
        } else {
            return batch.getProgress();
        }
    }
}
