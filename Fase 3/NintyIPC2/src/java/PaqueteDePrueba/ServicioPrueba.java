/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PaqueteDePrueba;

import static java.lang.Integer.parseInt;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.ws.rs.GET;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.sql.Statement;


/**
 *
 * @author alonz
 */
@WebService(serviceName = "ServicioPrueba")
public class ServicioPrueba {
    
   
    /**
     * Web service operation
     * @param nombre
     * @param apellido
     * @param correo
     * @param notarjeta
     * @param rol
     * @param suscription
     * @param nusuarios
     * @param contrasena
     */
    @WebMethod(operationName = "AgregarAdmin")
    public void AgregarAdmin(@WebParam(name = "nombre") String nombre, @WebParam(name = "apellido") String apellido, @WebParam(name = "correo") String correo, @WebParam(name = "notarjeta") String notarjeta, @WebParam(name = "rol") String rol, @WebParam(name = "suscription") String suscription, @WebParam(name = "nusuarios") String nusuarios, @WebParam(name = "contrasena") String contrasena) {
        //TODO write your implementation code here:
        Administrador admin = new Administrador();          
        admin.connect();
        admin.createAdmin(nombre, apellido, correo, notarjeta, rol, suscription, nusuarios, contrasena);
    } 
    /**
     * Web service operation
     * @param correo
     * @param contrasena
     * @return 
     */
    @WebMethod(operationName = "ConsultarUsuario")
    public String ConsultarUsuario(@WebParam(name = "correo") String correo, @WebParam(name = "contrasena") String contrasena) {
        //TODO write your implementation code here:
        Administrador admin = new Administrador(); 
        admin.connect();
        return admin.ConsultarUsuario(correo, contrasena);
} 

    /**
     * Web service operation
     * @param hello
     * @return 
     */
    @WebMethod(operationName = "hello")
    public String hello(@WebParam(name = "hello") String hello) {
        //TODO write your implementation code here:
        return "hola "+hello;
    } 
    
    @WebMethod(operationName = "Prueba2")
    public String Prueba2(@WebParam(name = "nombre") String nombre, @WebParam(name = "apellido") String apellido, @WebParam(name = "correo") String correo, @WebParam(name = "notarjeta") String notarjeta, @WebParam(name = "rol") String rol, @WebParam(name = "suscription") String suscription, @WebParam(name = "nusuarios") String nusuarios, @WebParam(name = "contrasena") String contrasena) {
        
        try{
            String url = "jdbc:postgresql://localhost/ipcusuarios";
            String user = "postgres";
            String password = "toor";
            Connection conn = DriverManager.getConnection(url, user, password);
            PreparedStatement stmt = conn.prepareStatement("INSERT INTO administrador(nombre, apellido, correo,notarjeta,rol,suscripcion,nusuarios,contrasena) VALUES (?,?,?,?,?,?,?,?)");
            stmt.setString(1, nombre);
            stmt.setString(2, apellido);
            stmt.setString(3, correo);
            stmt.setString(4, notarjeta);
            stmt.setInt(5, parseInt(rol));
            stmt.setInt(6, parseInt(suscription));
            stmt.setInt(7,parseInt(nusuarios));
            stmt.setString(8, contrasena);            
            stmt.executeUpdate();
            return "si se pudo";
        }catch(SQLException e){
            return e.getMessage();
        }
    } 
}
