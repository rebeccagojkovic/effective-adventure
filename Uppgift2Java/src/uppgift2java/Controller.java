/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package uppgift2java;

import org.tempuri.ArrayOfCustomer;
import org.tempuri.ArrayOfString;

/**
 *
 * @author erik.aberg
 */
public class Controller {

    public static ArrayOfString getCustomers() {
        org.tempuri.WebService service = new org.tempuri.WebService();
        org.tempuri.WebServiceSoap port = service.getWebServiceSoap12();
        return port.getCustomers();
    }

    public static ArrayOfCustomer readCustomer() {
        org.tempuri.WebService service = new org.tempuri.WebService();
        org.tempuri.WebServiceSoap port = service.getWebServiceSoap12();
        return port.readCustomer();
    }
    
}
