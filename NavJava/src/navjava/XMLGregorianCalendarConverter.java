/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package navjava;

import java.sql.Timestamp;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDateTime;
import java.util.Date;
import java.util.GregorianCalendar;
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
            Timestamp time = new Timestamp(date.getTime());
            GregorianCalendar gc = (GregorianCalendar) GregorianCalendar.getInstance();
            gc.setTime(time);
            return DatatypeFactory.newInstance().newXMLGregorianCalendar(gc);
        } catch (DatatypeConfigurationException e) {
            // TODO: Optimize exception handling
            System.out.print(e.getMessage());
            return null;
        }
    }

    public static XMLGregorianCalendar dateToXMLGregorianCalendar1(Date date) {

        try {
            Timestamp time = new Timestamp(new Date().getTime());
            LocalDateTime ldt = time.toLocalDateTime();
            XMLGregorianCalendar cal = DatatypeFactory.newInstance().newXMLGregorianCalendar();

            cal.setYear(ldt.getYear());
            cal.setMonth(ldt.getMonthValue());
            cal.setDay(ldt.getDayOfMonth());
            cal.setHour(ldt.getHour());
            cal.setMinute(ldt.getMinute());
            cal.setSecond(ldt.getSecond());
            // cal.setFractionalSecond(new BigDecimal("0." + ldt.getNano()));

            return cal;//DatatypeFactory.newInstance().newXMLGregorianCalendar(cal);
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
