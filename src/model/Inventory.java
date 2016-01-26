package model;

class Inventory {

    public String iName;
    public String totalAmount;
    public String latestDeliveryAmount;
    public String latestDeliveryDate;

    public Inventory(String iName, String totalAmount, String latestDeliveryAmount, String latestDeliveryDate) {
        this.iName = iName;
        this.totalAmount = totalAmount;
        this.latestDeliveryAmount = latestDeliveryAmount;
        this.latestDeliveryDate = latestDeliveryDate;
    }
}
