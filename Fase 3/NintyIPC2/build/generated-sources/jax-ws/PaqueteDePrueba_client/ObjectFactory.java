
package PaqueteDePrueba_client;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the PaqueteDePrueba_client package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _AgregarAdmin_QNAME = new QName("http://PaqueteDePrueba/", "AgregarAdmin");
    private final static QName _AgregarAdminResponse_QNAME = new QName("http://PaqueteDePrueba/", "AgregarAdminResponse");
    private final static QName _Hello_QNAME = new QName("http://PaqueteDePrueba/", "hello");
    private final static QName _HelloResponse_QNAME = new QName("http://PaqueteDePrueba/", "helloResponse");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: PaqueteDePrueba_client
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link AgregarAdmin }
     * 
     */
    public AgregarAdmin createAgregarAdmin() {
        return new AgregarAdmin();
    }

    /**
     * Create an instance of {@link AgregarAdminResponse }
     * 
     */
    public AgregarAdminResponse createAgregarAdminResponse() {
        return new AgregarAdminResponse();
    }

    /**
     * Create an instance of {@link Hello }
     * 
     */
    public Hello createHello() {
        return new Hello();
    }

    /**
     * Create an instance of {@link HelloResponse }
     * 
     */
    public HelloResponse createHelloResponse() {
        return new HelloResponse();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link AgregarAdmin }{@code >}
     * 
     * @param value
     *     Java instance representing xml element's value.
     * @return
     *     the new instance of {@link JAXBElement }{@code <}{@link AgregarAdmin }{@code >}
     */
    @XmlElementDecl(namespace = "http://PaqueteDePrueba/", name = "AgregarAdmin")
    public JAXBElement<AgregarAdmin> createAgregarAdmin(AgregarAdmin value) {
        return new JAXBElement<AgregarAdmin>(_AgregarAdmin_QNAME, AgregarAdmin.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link AgregarAdminResponse }{@code >}
     * 
     * @param value
     *     Java instance representing xml element's value.
     * @return
     *     the new instance of {@link JAXBElement }{@code <}{@link AgregarAdminResponse }{@code >}
     */
    @XmlElementDecl(namespace = "http://PaqueteDePrueba/", name = "AgregarAdminResponse")
    public JAXBElement<AgregarAdminResponse> createAgregarAdminResponse(AgregarAdminResponse value) {
        return new JAXBElement<AgregarAdminResponse>(_AgregarAdminResponse_QNAME, AgregarAdminResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link Hello }{@code >}
     * 
     * @param value
     *     Java instance representing xml element's value.
     * @return
     *     the new instance of {@link JAXBElement }{@code <}{@link Hello }{@code >}
     */
    @XmlElementDecl(namespace = "http://PaqueteDePrueba/", name = "hello")
    public JAXBElement<Hello> createHello(Hello value) {
        return new JAXBElement<Hello>(_Hello_QNAME, Hello.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link HelloResponse }{@code >}
     * 
     * @param value
     *     Java instance representing xml element's value.
     * @return
     *     the new instance of {@link JAXBElement }{@code <}{@link HelloResponse }{@code >}
     */
    @XmlElementDecl(namespace = "http://PaqueteDePrueba/", name = "helloResponse")
    public JAXBElement<HelloResponse> createHelloResponse(HelloResponse value) {
        return new JAXBElement<HelloResponse>(_HelloResponse_QNAME, HelloResponse.class, null, value);
    }

}
