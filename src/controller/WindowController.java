package controller;

import java.awt.event.WindowEvent;
import java.awt.event.WindowListener;
import model.Database;
import view.KrustyGUI;

/**
 *
 * @author arno
 */
public class WindowController implements WindowListener {

    Database db;
    KrustyGUI gui;

    public WindowController(KrustyGUI gui, Database db) {
        this.db = db;
        this.gui = gui;
        gui.addWindowListener(this);
        gui.setVisible(true);
    }

    @Override
    public void windowOpened(WindowEvent we) {
    }

    @Override
    public void windowClosing(WindowEvent we) {
        gui.setVisible(false);
        db.closeConnection();
        System.exit(0);
    }

    @Override
    public void windowClosed(WindowEvent we) {
    }

    @Override
    public void windowIconified(WindowEvent we) {
    }

    @Override
    public void windowDeiconified(WindowEvent we) {
    }

    @Override
    public void windowActivated(WindowEvent we) {
    }

    @Override
    public void windowDeactivated(WindowEvent we) {
    }
}
