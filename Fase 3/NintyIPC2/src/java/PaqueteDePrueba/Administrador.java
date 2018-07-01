/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PaqueteDePrueba;

import static java.lang.Integer.parseInt;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

/**
 *
 * @author alonz
 */
public class Administrador {
    private final String url = "jdbc:postgresql://localhost/ipcusuarios";
    private final String user = "postgres";
    private final String password = "toor";
    public String test="";
    public Connection connect() {
    
    Connection conn = null;
    try {
        conn = DriverManager.getConnection(url, user, password);
        System.out.println("Connected DBZ successfully.");
        test="Connected DBZ successfully.";

    } catch (SQLException e) {
        System.out.println(e.getMessage()+" eso esta mal "+ e.getSQLState());
        test="e.getMessage()+\" eso esta mal \"+ e.getSQLState()";
    }

    return conn;
}
    public void createAdmin(String nombre, String apellido, String correo, String notarjeta,String rol,String suscripcion,String nousuarios,String contra) {
    try {
        //Statement stmnt = null;
        PreparedStatement stmt = connect().prepareStatement("INSERT INTO administrador(nombre, apellido, correo,notarjeta,rol,suscripcion,nusuarios,contrasena) VALUES (?,?,?,?,?,?,?,?)");
            stmt.setString(1, nombre);
            stmt.setString(2, apellido);
            stmt.setString(3, correo);
            stmt.setString(4, notarjeta);
            stmt.setInt(5, parseInt(rol));
            stmt.setInt(6, parseInt(suscripcion));
            stmt.setInt(7,parseInt(nousuarios));
            stmt.setString(8, contra);            
            stmt.executeUpdate();

    } catch (SQLException e) {
        System.out.println(e.getMessage());
    }
}
 public String ConsultarUsuario(String correo,String contra) {
    try {
        Statement st = connect().createStatement();
        ResultSet rs = st.executeQuery("SELECT*FROM administrador WHERE correo = '"+correo+"' and contrasena = '"+ contra +"';");
        if(rs.next()){
           return rs.getString(1);
        }
        return "";
    } catch (SQLException e) {
        System.out.println(e.getMessage());
        return "";
    }
}
}
