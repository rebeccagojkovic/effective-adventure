/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package navjava;

import java.util.ArrayList;
import java.util.List;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author erik.aberg
 */
public class EmployeeTable{

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
}
