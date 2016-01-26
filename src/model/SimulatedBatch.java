package model;

import java.util.Observable;

public class SimulatedBatch extends Observable {

    int progress;
    String pName;
    int nbrPallets;

    public SimulatedBatch(String pName, int nbrPallets) {
        this.pName = pName;
        this.nbrPallets = nbrPallets;
        this.progress = 0;
        if (this.nbrPallets == 0) {
            System.out.println("cannot be zero");
            this.nbrPallets = 1;
        }
    }

    synchronized public int getProgress() {
        return this.progress;
    }

    synchronized public String getPName() {
        return this.pName;
    }

    synchronized public int getNbrPallets() {
        return this.nbrPallets;
    }

    synchronized void tick() {
        progress = progress + 100 / nbrPallets;
        if (progress > 100) {
            progress = 100;
        }
        setChanged();
        notifyObservers();
    }
}
