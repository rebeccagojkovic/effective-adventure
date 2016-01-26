package model;

import java.sql.*;
import java.util.ArrayList;
import java.util.Observable;
import javax.swing.ComboBoxModel;
import javax.swing.DefaultComboBoxModel;

/**
 * Database is a class that specifies the interface to the movie database. Uses
 * JDBC and the MySQL Connector/J driver.
 */
public class Database extends Observable {

    /**
     * The database connection.
     */
    private Connection conn;

    /**
     * Create the database interface object. Connection to the database is
     * performed later.
     */
    public Database() {
        conn = null;
    }

    /**
     * Open a connection to the database, using the specified user name and
     * password.
     *
     * @param userName
     *            The user name.
     * @param password
     *            The user's password.
     * @return true if the connection succeeded, false if the supplied user name
     *         and password were not recognized. Returns false also if the JDBC
     *         driver isn't found.
     */
    synchronized public boolean openConnection(String userName, String password) {
        try {
            Class.forName("com.mysql.jdbc.Driver");
            conn = DriverManager.getConnection(
                    "jdbc:mysql://puccini.cs.lth.se/" + userName, userName,
                    password);
        } catch (SQLException e) {
            e.printStackTrace();
            return false;
        } catch (ClassNotFoundException e) {
            e.printStackTrace();
            return false;
        }
        return true;
    }

    /**
     * Close the connection to the database.
     */
    synchronized public void closeConnection() {
        try {
            if (conn != null) {
                conn.close();
            }
        } catch (SQLException e) {
        }
        conn = null;
    }

    /**
     * Check if the connection to the database has been established
     *
     * @return true if the connection has been established
     */
    synchronized public boolean isConnected() {
        return conn != null;
    }

    synchronized public boolean userExists(String userId) {
        try {
            PreparedStatement userExists = conn.prepareStatement(
                    "select count(username) from Users where username = ?");
            userExists.setString(1, userId);
            ResultSet rs = userExists.executeQuery();

            int result = 0;
            if (rs.next()) {
                result = rs.getInt(1);
            }

            if (result == 1) {
                return true;
            } else {
                return false;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return false;
    }

    synchronized public ComboBoxModel getProducts() {
        try {
            PreparedStatement countRows = conn.prepareStatement(
                    "select count(*) from Products");
            ResultSet cr = countRows.executeQuery();
            cr.next();
            int count = cr.getInt(1);

            PreparedStatement productList = conn.prepareStatement(
                    "select pName from Products");
            ResultSet rs = productList.executeQuery();
            String[] result = new String[count];
            int i = 0;
            while (rs.next()) {
                String str = rs.getString("pName");
                result[i] = str;
                i++;
            }
            return new DefaultComboBoxModel(result);
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }

    synchronized public ComboBoxModel getProductsInStorage() {
        try {
            PreparedStatement countRows = conn.prepareStatement(
                    "select count(DISTINCT pName) from Pallets where timestamp is not null");
            ResultSet cr = countRows.executeQuery();
            cr.next();
            int count = cr.getInt(1);

            if (count == 0) {
                return new DefaultComboBoxModel(new String[]{"Storage is empty"});
            } else {
                PreparedStatement productList = conn.prepareStatement(
                        "select pName from Pallets where timestamp is not null group by pName");
                ResultSet rs = productList.executeQuery();
                String[] result = new String[count];
                int i = 0;
                while (rs.next()) {
                    String str = rs.getString("pName");
                    result[i] = str;
                    i++;
                }
                return new DefaultComboBoxModel(result);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }

    synchronized public StorageModel getPalletsInStorage() {
        try {
            PreparedStatement countRows = conn.prepareStatement(
                    "select count(*) from Pallets where timestamp is not null");
            ResultSet cr = countRows.executeQuery();
            cr.next();
            int count = cr.getInt(1);

            if (count == 0) {
                return null;
            } else {
                PreparedStatement productList = conn.prepareStatement(
                        "select idNbr, pName, timestamp, isBlocked from Pallets where timestamp is not null");
                ResultSet rs = productList.executeQuery();

                int i = 0;
                StorageModel newModel = new StorageModel();
                while (rs.next()) {
                    int idNbr = rs.getInt("idNbr");
                    String pName = rs.getString("pName");
                    String timestamp = rs.getString("timestamp");
                    boolean isBlocked = rs.getBoolean("isBlocked");
                    newModel.addPallet(idNbr, pName, timestamp, isBlocked);
                    i++;
                }
                return newModel;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }

    synchronized public StorageModel getPalletsFromIdNbr(ArrayList<Integer> idList) {
        try {
            PreparedStatement countRows = conn.prepareStatement(
                    "select count(*) from Pallets where idNbr= ?");
            countRows.setInt(1, idList.get(0));
            ResultSet cr = countRows.executeQuery();
            cr.next();
            int count = cr.getInt(1);

            if (count == 0) {
                return null;
            } else {
                PreparedStatement productList = conn.prepareStatement(
                        "select idNbr, pName, timestamp, isBlocked from Pallets where idNbr= ?");
                StorageModel newModel = new StorageModel();
                for (int i = 0; i < idList.size(); i++) {
                    productList.setInt(1, idList.get(i));
                    ResultSet rs = productList.executeQuery();
                    rs.next();
                    int idNbr = rs.getInt("idNbr");
                    String pName = rs.getString("pName");
                    String timestamp = rs.getString("timestamp");
                    boolean isBlocked = rs.getBoolean("isBlocked");

                    newModel.addPallet(idNbr, pName, timestamp, isBlocked);
                }
                return newModel;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }

    synchronized public StorageModel searchPID(int pid) {
        ArrayList<Integer> searchList = new ArrayList<Integer>();
        searchList.add(pid);

        return getPalletsFromIdNbr(searchList);
    }

    synchronized public StorageModel searchProductName(String searchPName) {
        try {
            PreparedStatement countRows = conn.prepareStatement(
                    "select count(*) from Pallets where pName= ?");
            countRows.setString(1, searchPName);
            ResultSet cr = countRows.executeQuery();
            cr.next();
            int count = cr.getInt(1);

            if (count == 0) {
                return null;
            } else {
                PreparedStatement productList = conn.prepareStatement(
                        "select idNbr, pName, timestamp, isBlocked from Pallets where pName= ?");
                productList.setString(1, searchPName);
                ResultSet rs = productList.executeQuery();

                int i = 0;
                StorageModel newModel = new StorageModel();
                while (rs.next()) {
                    int idNbr = rs.getInt("idNbr");
                    String pName = rs.getString("pName");
                    String timestamp = rs.getString("timestamp");
                    boolean isBlocked = rs.getBoolean("isBlocked");
                    newModel.addPallet(idNbr, pName, timestamp, isBlocked);
                    i++;
                }
                return newModel;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }

    synchronized public StorageModel search(String searchName, String searchFromTimestamp, String searchToTimestamp) {
        try {
            PreparedStatement countRows = conn.prepareStatement(
                    "select count(*) from Pallets where timestamp is not null and pName = ? and timestamp >= ? and timestamp <= ?");
            countRows.setString(1, searchName);
            countRows.setString(2, searchFromTimestamp);
            countRows.setString(3, searchToTimestamp);

            ResultSet cr = countRows.executeQuery();
            cr.next();
            int count = cr.getInt(1);

            if (count == 0) {
                return null;
            } else {
                PreparedStatement productList = conn.prepareStatement(
                        "select idNbr, pName, timestamp, isBlocked from Pallets where timestamp is not null and pName=? and timestamp >= ? and timestamp <= ?");
                productList.setString(1, searchName);
                productList.setString(2, searchFromTimestamp);
                productList.setString(3, searchToTimestamp);

                ResultSet rs = productList.executeQuery();

                int i = 0;
                StorageModel newModel = new StorageModel();
                while (rs.next()) {
                    int idNbr = rs.getInt("idNbr");
                    String pName = rs.getString("pName");
                    String timestamp = rs.getString("timestamp");
                    boolean isBlocked = rs.getBoolean("isBlocked");
                    newModel.addPallet(idNbr, pName, timestamp, isBlocked);
                    i++;
                }
                return newModel;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }

    synchronized public boolean toggleBlock(boolean status, int idNbr) {
        try {
            PreparedStatement togglePallet = conn.prepareStatement(
                    "update Pallets set isBlocked=? where idNbr = ?;");
            togglePallet.setBoolean(1, status);
            togglePallet.setInt(2, idNbr);

            int result = togglePallet.executeUpdate();

            setChanged();
            notifyObservers();

            if (result == 1) {
                return true;
            } else {
                return false;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return false;
    }

    synchronized public boolean addPallet(String pName, String timestamp) {
        try {
            PreparedStatement addPallet = conn.prepareStatement(
                    "insert into Pallets values(0, ?, ?, false )");
            addPallet.setString(1, pName);
            addPallet.setString(2, timestamp);

            int result = addPallet.executeUpdate();

            setChanged();
            notifyObservers();

            if (result == 1) {
                return true;
            } else {
                return false;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return false;
    }

    synchronized public IngredientBoolean canHasInventory(int numPallets, String pName) {
        IngredientBoolean ib = new IngredientBoolean("cowbell", true, 42, 42, "rings");
        try {
            PreparedStatement canHasIngredients = conn.prepareStatement("select iName,amount*?,totalAmount,unit from Quantities natural join Ingredients where pName=? and amount*? > totalAmount");

            canHasIngredients.setInt(1, numPallets);
            canHasIngredients.setString(2, pName);
            canHasIngredients.setInt(3, numPallets);

            ResultSet rs;
            rs = canHasIngredients.executeQuery();
            while (rs.next()) {
                ib.yesWeCan = false;
                ib.iName = rs.getString(1);
                ib.amount = rs.getInt(2);
                ib.totalAmount = rs.getInt(3);
                ib.unit = rs.getString(4);
                return ib;
            }
            return ib;
        } catch (SQLException e) {
            e.printStackTrace();
            ib.yesWeCan = false;
            ib.iName = "krustyness";
            return ib;
        }
    }

    synchronized public boolean updateInventory(int nbrPallets, String pName) {
        try {
            int result;
            PreparedStatement getIngredients = conn.prepareStatement(
                    "select iName,amount from Quantities where pName=?");
            getIngredients.setString(1, pName);
            ResultSet rs;
            ArrayList<Ingredient> ingredients = new ArrayList<Ingredient>();
            rs = getIngredients.executeQuery();
            while (rs.next()) {
                ingredients.add(new Ingredient(rs.getString(1), rs.getInt(2)));
            }

            for (Ingredient i : ingredients) {
                PreparedStatement updateIngredientInventory = conn.prepareStatement(
                        "update Ingredients set totalAmount=totalAmount - (select amount from Quantities where pName=? and iName=?)*? where iName = ?");
                updateIngredientInventory.setString(1, pName);
                updateIngredientInventory.setString(2, i.iName);
                updateIngredientInventory.setInt(3, nbrPallets);
                updateIngredientInventory.setString(4, i.iName);

                result = updateIngredientInventory.executeUpdate();

                if (result == 1) {
                    return true;
                } else {
                    return false;
                }
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return false;
    }

    synchronized ArrayList<Inventory> getInventory() {
        try {
            PreparedStatement getInventory = conn.prepareStatement(
                    "select * from Ingredients");
            ResultSet rs;
            ArrayList<Inventory> inventory = new ArrayList<Inventory>();
            rs = getInventory.executeQuery();
            while (rs.next()) {
                inventory.add(new Inventory(rs.getString(1), rs.getString(2), rs.getString(3), rs.getString(4)));
            }
            return inventory;
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }
}
