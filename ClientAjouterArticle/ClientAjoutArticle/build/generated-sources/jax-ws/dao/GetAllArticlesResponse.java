
package dao;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Classe Java pour anonymous complex type.
 * 
 * <p>Le fragment de schéma suivant indique le contenu attendu figurant dans cette classe.
 * 
 * <pre>
 * &lt;complexType&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="GetAllArticlesResult" type="{http://schemas.datacontract.org/2004/07/InfosWCFService}ArrayOfArticle" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "getAllArticlesResult"
})
@XmlRootElement(name = "GetAllArticlesResponse")
public class GetAllArticlesResponse {

    @XmlElementRef(name = "GetAllArticlesResult", namespace = "http://tempuri.org/", type = JAXBElement.class, required = false)
    protected JAXBElement<ArrayOfArticle> getAllArticlesResult;

    /**
     * Obtient la valeur de la propriété getAllArticlesResult.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfArticle }{@code >}
     *     
     */
    public JAXBElement<ArrayOfArticle> getGetAllArticlesResult() {
        return getAllArticlesResult;
    }

    /**
     * Définit la valeur de la propriété getAllArticlesResult.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link ArrayOfArticle }{@code >}
     *     
     */
    public void setGetAllArticlesResult(JAXBElement<ArrayOfArticle> value) {
        this.getAllArticlesResult = value;
    }

}
