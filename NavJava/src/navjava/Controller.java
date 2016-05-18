/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package navjava;

import javax.swing.table.DefaultTableModel;
import org.tempuri.ArrayOfEmployee;
import org.tempuri.ArrayOfEmployeeAbsence;
import org.tempuri.ArrayOfEmployeeMeta;
import org.tempuri.ArrayOfEmployeeRelative;

/**
 *
 * @author erik.aberg
 */
public class Controller {

    public static void addEmployee(java.lang.String id, java.lang.String firstName, java.lang.String middleName, java.lang.String lastName, java.lang.String initials, java.lang.String jobTitle, java.lang.String searchName, java.lang.String adress, java.lang.String adress2, java.lang.String city, java.lang.String postCode, java.lang.String county, java.lang.String phoneNumber, java.lang.String mobilePhoneNumber, java.lang.String eMail, java.lang.String altAdress, javax.xml.datatype.XMLGregorianCalendar altAdressStart, javax.xml.datatype.XMLGregorianCalendar altAdressEnd, java.lang.String picture, javax.xml.datatype.XMLGregorianCalendar birthDate, java.lang.String socialSecurityNumber, java.lang.String unionCode, java.lang.String unionMembershipNumber, int sex, java.lang.String countryRegionCode, java.lang.String managerNumber, java.lang.String employmentContractCode, java.lang.String statisticsGroupCode, javax.xml.datatype.XMLGregorianCalendar employmentDate, int status, javax.xml.datatype.XMLGregorianCalendar inactivityDate, java.lang.String causeOfInactivity, javax.xml.datatype.XMLGregorianCalendar terminationDate, java.lang.String groundsForTermCode, java.lang.String globalDimension1Code, java.lang.String globalDimension2Code, java.lang.String resourceNumber, javax.xml.datatype.XMLGregorianCalendar lastDateModified, java.lang.String extension, java.lang.String pager, java.lang.String faxNumber, java.lang.String companyEmail, java.lang.String title, java.lang.String salesPerPurchCode, java.lang.String noSeries) {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        port.addEmployee(id, firstName, middleName, lastName, initials, jobTitle, searchName, adress, adress2, city, postCode, county, phoneNumber, mobilePhoneNumber, eMail, altAdress, altAdressStart, altAdressEnd, picture, birthDate, socialSecurityNumber, unionCode, unionMembershipNumber, sex, countryRegionCode, managerNumber, employmentContractCode, statisticsGroupCode, employmentDate, status, inactivityDate, causeOfInactivity, terminationDate, groundsForTermCode, globalDimension1Code, globalDimension2Code, resourceNumber, lastDateModified, extension, pager, faxNumber, companyEmail, title, salesPerPurchCode, noSeries);
    }

    public static void addEmployeeMini(java.lang.String id, java.lang.String firstName, java.lang.String lastName) {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        port.addEmployeeMini(id, firstName, lastName);

    }

    public static void deleteEmployee(java.lang.String id) {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        port.deleteEmployee(id);
    }

    public static ArrayOfEmployeeMeta getAllTables() {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        return port.getAllTables();
    }

    public static ArrayOfEmployeeMeta getAllTables2() {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        return port.getAllTables2();
    }

    public static ArrayOfEmployeeMeta getConstraints() {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        return port.getConstraints();
    }

    public static ArrayOfEmployee getEmployee(java.lang.String id) {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        return port.getEmployee(id);
    }

    public static ArrayOfEmployeeAbsence getEmployeeAbsence() {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        return port.getEmployeeAbsence();
    }

    public static ArrayOfEmployee getEmployees() {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        return port.getEmployees();
    }

    public static ArrayOfEmployeeMeta getEmployeesMeta() {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        return port.getEmployeesMeta();
    }

    public static ArrayOfEmployeeMeta getEmployeesMeta2() {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        return port.getEmployeesMeta2();
    }

    public static ArrayOfEmployeeMeta getIndexes() {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        return port.getIndexes();
    }

    public static ArrayOfEmployeeMeta getKeys() {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        return port.getKeys();
    }

    public static ArrayOfEmployeeRelative getRelative() {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        return port.getRelative();
    }

    public static ArrayOfEmployee getSickestEmployee() {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        return port.getSickestEmployee();
    }

    public static void updateEmployee(java.lang.String id, java.lang.String firstName) {
        org.tempuri.WebService1 service = new org.tempuri.WebService1();
        org.tempuri.WebService1Soap port = service.getWebService1Soap12();
        port.updateEmployee(id, firstName);
    }

    public static DefaultTableModel GetEmployeesTable() {
        return EmployeeTable.GetEmployeesTable();
    }

    public static DefaultTableModel GetEmployeesMetaTable() {
        return EmployeeTable.GetEmployeesMetaTable();
    }

    public static DefaultTableModel GetEmployeesMetaTable2() {
        return EmployeeTable.GetEmployeesMetaTable2();
    }

    public static DefaultTableModel GetConstraintsTable() {
        return EmployeeTable.GetConstraintsTable();
    }

    public static DefaultTableModel GetEmployeeAbsenceTable() {
        return EmployeeTable.GetEmployeeAbsenceTable();
    }

    public static DefaultTableModel GetEmployeeMeta() {
        return EmployeeTable.GetEmployeesMeta();
    }

    public static DefaultTableModel GetEmployeeMeta2() {
        return EmployeeTable.GetEmployeesMeta2();
    }

    public static DefaultTableModel GetIndexes() {
        return EmployeeTable.GetIndexes();
    }

    public static DefaultTableModel GetKeys() {
        return EmployeeTable.GetKeys();
    }

    public static DefaultTableModel GetRelative() {
        return EmployeeTable.GetRelative();
    }

    public static DefaultTableModel GetSickestEmployee() {
        return EmployeeTable.GetSickestEmployee();
    }

    public static DefaultTableModel GetEmployee(String id) {
        return EmployeeTable.GetEmployee(id);
    }
}
