/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package navjava;

import java.sql.Timestamp;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Locale;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.Locale;
import javax.xml.datatype.DatatypeConfigurationException;
import javax.xml.datatype.DatatypeFactory;
import javax.xml.datatype.XMLGregorianCalendar;

/**
 * Converts different objects into XMLGregorianCalendar
 */
public class XMLGregorianCalendarConverter {

    /**
     * @param args the command line arguments
     */
//    public static void main(String[] args) throws ParseException {
//
//        Date date = new Date();
//        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd'T'HH:mm:ss.SSS z", Locale.GERMAN);
//
//        String formattedDate = sdf.format(date);
//
//        System.out.printf("%-24s %s%n", "String:", stringToXMLGregorianCalendar(formattedDate, sdf));
//    }
    /**
     * Converts Date object into XMLGregorianCalendar
     *
     * @param date Object to be converted
     * @return XMLGregorianCalendar
     */
    public static XMLGregorianCalendar dateToXMLGregorianCalendar(Date date) {

        try {
            GregorianCalendar gc = (GregorianCalendar) GregorianCalendar.getInstance();
            gc.setTime(new Timestamp(date.getTime()));
            return DatatypeFactory.newInstance().newXMLGregorianCalendar(gc);
        } catch (DatatypeConfigurationException e) {
            // TODO: Optimize exception handling
            System.out.print(e.getMessage());
            return null;
        }
    }

    /**
     * Converts a formatted string into XMLGregorianCalendar
     *
     * @param datetime Formatted string
     * @param sdf Date format of the given string
     * @return XMLGregorianCalendar
     */
    public static XMLGregorianCalendar stringToXMLGregorianCalendar(String datetime, SimpleDateFormat sdf) {

        try {
            Date date = sdf.parse(datetime);
            return dateToXMLGregorianCalendar(date);
        } catch (ParseException e) {
            // TODO: Optimize exception handling
            System.out.print(e.getMessage());
            return null;
        }
    }
}
