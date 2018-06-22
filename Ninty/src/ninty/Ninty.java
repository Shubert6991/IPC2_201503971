/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package ninty;

import java.sql.Statement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 *
 * @author alonz
 */
public class Ninty {
    
private final String url = "jdbc:postgresql://localhost:5432/ipcusuarios";
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

public void createAdmin(String nombre, String apellido, String Correo) {
    try {
        Statement stmnt = null;
        stmnt = connect().createStatement();
        String sql = "INSERT INTO superadministrador (nombre,apellido,correo) "
                + "VALUES " + "(" + nombre + ", " + apellido + ", " + Correo + ")";
        stmnt.executeUpdate(sql);

    } catch (SQLException e) {
        System.out.println(e.getMessage());
    }

}

public static void main(String[] args) {
    Ninty database = new Ninty();
    database.connect();
    database.createAdmin("administrador1","test","test@test.com");

}
}
