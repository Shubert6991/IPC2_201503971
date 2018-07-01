/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package PaqueteDePrueba;

import javax.ws.rs.Consumes;
import javax.ws.rs.GET;
import javax.ws.rs.Path;
import javax.ws.rs.Produces;
import javax.ws.rs.QueryParam;
import javax.ws.rs.core.Context;
import javax.ws.rs.core.UriInfo;

/**
 * REST Web Service
 *
 * @author alonz
 */
@Path("serviciopruebaport")
public class ServicioPruebaPort {

    private PaqueteDePrueba_client.ServicioPrueba port;

    @Context
    private UriInfo context;

    /**
     * Creates a new instance of ServicioPruebaPort
     */
    public ServicioPruebaPort() {
        port = getPort();
    }

    /**
     * Invokes the SOAP method hello
     * @param hello resource URI parameter
     * @return an instance of java.lang.String
     */
    @GET
    @Produces("text/plain")
    @Consumes("text/plain")
    @Path("hello/")
    public String getHello(@QueryParam("hello") String hello) {
        try {
            // Call Web Service Operation
            if (port != null) {
                java.lang.String result = port.hello(hello);
                return result;
            }
        } catch (Exception ex) {
            // TODO handle custom exceptions here
        }
        return null;
    }

    /**
     * Invokes the SOAP method AgregarAdmin
     * @param nombre resource URI parameter
     * @param apellido resource URI parameter
     * @param correo resource URI parameter
     * @param notarjeta resource URI parameter
     * @param rol resource URI parameter
     * @param suscription resource URI parameter
     * @param nusuarios resource URI parameter
     * @param contrasena resource URI parameter
     * @return an instance of java.lang.String
     */
    @GET
    @Produces("text/plain")
    @Consumes("text/plain")
    @Path("agregaradmin/")
    public String getAgregarAdmin(@QueryParam("nombre") String nombre, @QueryParam("apellido") String apellido, @QueryParam("correo") String correo, @QueryParam("notarjeta") String notarjeta, @QueryParam("rol") String rol, @QueryParam("suscription") String suscription, @QueryParam("nusuarios") String nusuarios, @QueryParam("contrasena") String contrasena) {
        try {
            // Call Web Service Operation
            if (port != null) {
                java.lang.String result = port.agregarAdmin(nombre, apellido, correo, notarjeta, rol, suscription, nusuarios, contrasena);
                return result;
            }
        } catch (Exception ex) {
            // TODO handle custom exceptions here
        }
        return null;
    }

    /**
     *
     */
    private PaqueteDePrueba_client.ServicioPrueba getPort() {
        try {
            // Call Web Service Operation
            PaqueteDePrueba_client.ServicioPrueba_Service service = new PaqueteDePrueba_client.ServicioPrueba_Service();
            PaqueteDePrueba_client.ServicioPrueba p = service.getServicioPruebaPort();
            return p;
        } catch (Exception ex) {
            // TODO handle custom exceptions here
        }
        return null;
    }
}
