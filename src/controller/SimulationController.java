package controller;

import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Observable;
import java.util.Observer;
import model.Database;
import model.SimulatedBatch;
import model.SimulatedStorageModel;
import model.SimulationThread;
import model.StorageModel;
import view.KrustyGUI;

public class SimulationController implements Observer {

    KrustyGUI gui;
    Database db;
    SimulatedStorageModel ssm;
    StorageModel sm;

    public SimulationController(Database db, KrustyGUI gui, SimulatedStorageModel ssm, StorageModel sm) {
        this.db = db;
        this.gui = gui;
        this.ssm = ssm;
        this.sm = sm;
        SimulationThread simulationThread = new SimulationThread(ssm);
        simulationThread.start();
        this.gui.simulationTable.setModel(ssm);
    }

    public void produceCookies(String pName, int nbrPallets) {
        SimulatedBatch sb = new SimulatedBatch(pName, nbrPallets);
        sb.addObserver(this);
        db.updateInventory(nbrPallets, pName);
        ssm.addSimulatedBatch(sb);
    }

    public String getDate() {
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        return sdf.format(Calendar.getInstance().getTime());
    }

    @Override
    public void update(Observable o, Object o1) {
        SimulatedBatch sb = (SimulatedBatch) o;
        int progress = sb.getProgress();
        ssm.fireTableDataChanged();
        if (progress >= 100) {
            ssm.removeBatch(sb);
            for (int i = 0; i < sb.getNbrPallets(); i++) {
                db.addPallet(sb.getPName(), getDate());
            }
        }
    }
}
