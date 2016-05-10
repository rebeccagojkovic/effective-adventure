/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package uppgift1java;

/**
 *
 * @author erik.aberg
 */
public class Controller {

    public static String txtFile(java.lang.String filename) {
        org.tempuri.WebService service = new org.tempuri.WebService();
        org.tempuri.WebServiceSoap port = service.getWebServiceSoap12();
        return port.txtFile(filename);
    }
    
}
