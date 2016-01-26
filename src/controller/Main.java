package controller;

import java.awt.Image;
import javax.swing.ImageIcon;
import javax.swing.UIManager;
import model.Database;
import model.StorageModel;
import model.SimulatedStorageModel;
import view.KrustyGUI;

/**
 *
 * @author e03mo & dt05te2
 */
public class Main {

    public static void main(String[] args) {
        try {
            UIManager.setLookAndFeel(
                    UIManager.getSystemLookAndFeelClassName());
        } catch (Exception e) {
        }
        StorageModel sm = new StorageModel();
        SimulatedStorageModel ssm = new SimulatedStorageModel();
        Database db = new Database();
        KrustyGUI gui = new KrustyGUI();

        Image im = new ImageIcon("/view/frame_icon.png").getImage();
        gui.setIconImage(im);

        SimulationController simCtrl = new SimulationController(db, gui, ssm, sm);
        new ProductionController(gui, db, simCtrl);
        new StorageController(gui, db, sm);
        new InventoryController(db, gui);
    }
}
