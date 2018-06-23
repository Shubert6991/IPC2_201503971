
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.Statement;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author alonz
 */
public class SuperAdmin {
    private final String url = "jdbc:postgresql://localhost/ipcusuarios";
private final String user = "postgres";
private final String password = "toor";

public Connection connect() {
    
    Connection conn = null;
    try {
        conn = DriverManager.getConnection(url, user, password);
        System.out.println("Connected DBZ successfully.");

    } catch (SQLException e) {
        System.out.println(e.getMessage()+" la cagaste "+ e.getSQLState());
    }

    return conn;
}

public void createAdmin(String nombre1, String apellido1, String correo1) {
    try {
        //Statement stmnt = null;
        //stmnt = connect().createStatement();
        //String sql = "INSERT INTO superadministrador (idadminn,nombre,apellido,correo) "
                //+ "VALUES " + "("+1+"," + nombre1 + ", " + apellido1 + ", " + Correo1 + ")";
        //stmnt.executeUpdate(sql);
        PreparedStatement stmt = connect().prepareStatement("INSERT INTO superadministrador(idadminn, nombre, apellido, correo) VALUES (?, ?, ?,?)");
            stmt.setInt(1,100);
            stmt.setString(2, nombre1);
            stmt.setString(3, apellido1);
            stmt.setString(4, correo1);
            
            stmt.executeUpdate();

    } catch (SQLException e) {
        System.out.println(e.getMessage());
    }

}

public static void main(String[] args) {
    SuperAdmin database = new SuperAdmin();
    database.connect();
    database.createAdmin("administradortest","test","test@test.com");

}
}
