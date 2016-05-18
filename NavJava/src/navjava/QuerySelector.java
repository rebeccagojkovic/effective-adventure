/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package navjava;

/**
 *
 * @author erik.aberg
 */
public class QuerySelector {

    private String Name;

    private Object Value;

    public QuerySelector(String Name, Object Value) {
        this.Name = Name;
        this.Value = Value;
    }

    public String getName() {
        return Name;
    }

    public void setName(String Name) {
        this.Name = Name;
    }

    public Object getValue() {
        return Value;
    }

    public void setValue(Object Value) {
        this.Value = Value;
    }

//    public static String getQueries() {
//        QuerySelector[] things = new QuerySelector[2];
//        things[0] = new QuerySelector("The first thing", "");
//        things[1] = new QuerySelector("The second thing", "");
//        new QuerySelector().Name = "Hej";
//        Controller.GetEmployeesTable(new QuerySelector() { Name = "1", Value = Controller.getEmployees().getEmployee() });
//        return things;
//    }
}
