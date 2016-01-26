package model;

public class Pallet {

    String pName;
    int idNbr;
    boolean isBlocked;
    String timestamp;

    public Pallet(int idNbr, String pName, String timestamp, boolean isBlocked) {
        this.pName = pName;
        this.idNbr = idNbr;
        this.isBlocked = isBlocked;
        this.timestamp = timestamp;
    }

    public void setPName(String pName) {
        this.pName = pName;
    }

    public String getPName() {
        return this.pName;
    }

    public void setIdNbr(int idNbr) {
        this.idNbr = idNbr;
    }

    public int getIdNbr() {
        return this.idNbr;
    }

    public void setIsBlocked(boolean blocked) {
        this.isBlocked = blocked;
    }

    public boolean getIsBlocked() {
        return this.isBlocked;
    }

    public void setTimeStamp(String time) {
        this.timestamp = time;
    }

    public String getTimeStamp() {
        return this.timestamp;
    }
}
