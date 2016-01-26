package model;

public class SimulationThread extends Thread {

    SimulatedStorageModel ssm;

    public SimulationThread(SimulatedStorageModel ssm) {
        super();
        this.ssm = ssm;
    }

    @Override
    public void run() {
        while (true) {
            try {
                Thread.sleep(1000);
            } catch (InterruptedException ex) {
            }
            for (SimulatedBatch sb : ssm.getSimulatedBatches()) {
                sb.tick();
            }
        }
    }
}
