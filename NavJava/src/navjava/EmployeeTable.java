/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package navjava;

import java.util.List;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author erik.aberg
 */
public class EmployeeTable {

    public static DefaultTableModel GetEmployeesTable() {

        String columnNames[] = {"EmployeeNo", "FirstName", "LastName"};
        List<org.tempuri.Employee> list = Controller.getEmployees().getEmployee();

        DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

        for (org.tempuri.Employee s : list) {
            Object[] o = new Object[5];
            o[0] = s.getEmployeeNo();
            o[1] = s.getFirstName();
            o[2] = s.getLastName();

            model.addRow(o);
        }
        return model;
    }

    public static DefaultTableModel GetEmployeesMetaTable2() {
        String columnNames[] = {"EmployeeNo", "FirstName", "LastName"};
        List<org.tempuri.EmployeeMeta> list = Controller.getEmployeesMeta2().getEmployeeMeta();

        DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

        for (org.tempuri.EmployeeMeta s : list) {
            Object[] o = new Object[5];
            o[0] = s.getColumnName();
            o[1] = s.getConstraintName();
            o[2] = s.getTableName();
            o[3] = s.getObjectID();

            model.addRow(o);
        }
        return model;
    }

    public static DefaultTableModel GetEmployeesMetaTable() {
        String columnNames[] = {"ColumnName", "ConstraintName", "TableName", "ObjectID"};
        List<org.tempuri.EmployeeMeta> list = Controller.getEmployeesMeta().getEmployeeMeta();

        DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

        for (org.tempuri.EmployeeMeta s : list) {
            Object[] o = new Object[5];
            o[0] = s.getColumnName();
            o[1] = s.getConstraintName();
            o[2] = s.getTableName();
            o[3] = s.getObjectID();

            model.addRow(o);
        }
        return model;
    }

    public static DefaultTableModel GetConstraintsTable() {
        String columnNames[] = {"ConstraintName"};
        List<org.tempuri.EmployeeMeta> list = Controller.getConstraints().getEmployeeMeta();

        DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

        for (org.tempuri.EmployeeMeta s : list) {
            Object[] o = new Object[1];

            o[1] = s.getConstraintName();

            model.addRow(o);
        }
        return model;
    }

    public static DefaultTableModel GetEmployeeAbsenceTable() {
        String columnNames[] = {"CauseOfAnsenceCode", "EmployeeNumber"};
        List<org.tempuri.EmployeeAbsence> list = Controller.getEmployeeAbsence().getEmployeeAbsence();

        DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

        for (org.tempuri.EmployeeAbsence s : list) {
            Object[] o = new Object[2];
            o[0] = s.getCauseOfAbsenceCode();
            o[1] = s.getEmployeeNo();

            model.addRow(o);
        }
        return model;
    }

    public static DefaultTableModel GetEmployeesMeta() {
        String columnNames[] = {"TableName", "MetaData"};
        List<org.tempuri.EmployeeMeta> list = Controller.getEmployeesMeta().getEmployeeMeta();

        DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

        for (org.tempuri.EmployeeMeta s : list) {
            Object[] o = new Object[2];
            o[0] = s.getTableName();
            o[1] = s.getColumnName();

            model.addRow(o);
        }
        return model;
    }

    public static DefaultTableModel GetEmployeesMeta2() {
        String columnNames[] = {"TableName", "MetaData"};
        List<org.tempuri.EmployeeMeta> list = Controller.getEmployeesMeta2().getEmployeeMeta();

        DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

        for (org.tempuri.EmployeeMeta s : list) {
            Object[] o = new Object[2];
            o[0] = s.getTableName();
            o[1] = s.getColumnName();

            model.addRow(o);
        }
        return model;
    }

    public static DefaultTableModel GetIndexes() {
        String columnNames[] = {"TableName", "ObjectID"};
        List<org.tempuri.EmployeeMeta> list = Controller.getIndexes().getEmployeeMeta();

        DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

        for (org.tempuri.EmployeeMeta s : list) {
            Object[] o = new Object[2];
            o[0] = s.getTableName();
            o[1] = s.getObjectID();

            model.addRow(o);
        }
        return model;
    }

    public static DefaultTableModel GetKeys() {
        String columnNames[] = {"TableName", "ObjectID"};
        List<org.tempuri.EmployeeMeta> list = Controller.getKeys().getEmployeeMeta();

        DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

        for (org.tempuri.EmployeeMeta s : list) {
            Object[] o = new Object[2];
            o[0] = s.getTableName();
            o[1] = s.getObjectID();

            model.addRow(o);
        }
        return model;
    }

    public static DefaultTableModel GetRelative() {
        String columnNames[] = {"EmployeeNumber", "LineNumber}", "RelativeCode"};
        List<org.tempuri.EmployeeRelative> list = Controller.getRelative().getEmployeeRelative();

        DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

        for (org.tempuri.EmployeeRelative s : list) {
            Object[] o = new Object[3];
            o[0] = s.getEmployeeNo();
            o[1] = s.getLineNo();
            o[2] = s.getRelativeCode();
            model.addRow(o);
        }
        return model;
    }

    public static DefaultTableModel GetSickestEmployee() {
        String columnNames[] = {"First Name"};
        List<org.tempuri.Employee> list = Controller.getSickestEmployee().getEmployee();

        DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

        for (org.tempuri.Employee s : list) {
            Object[] o = new Object[1];
            o[0] = s.getFirstName();

            model.addRow(o);
        }
        return model;
    }

    public static DefaultTableModel GetEmployee(String id) {

        String columnNames[] = {"EmployeeNo", "FirstName", "LastName"};
        List<org.tempuri.Employee> list = Controller.getEmployee(id).getEmployee();

        DefaultTableModel model = new DefaultTableModel();

        model.setColumnIdentifiers(columnNames);

        for (org.tempuri.Employee s : list) {
            Object[] o = new Object[5];
            o[0] = s.getEmployeeNo();
            o[1] = s.getFirstName();
            o[2] = s.getLastName();

            model.addRow(o);
        }
        return model;
    }

}
