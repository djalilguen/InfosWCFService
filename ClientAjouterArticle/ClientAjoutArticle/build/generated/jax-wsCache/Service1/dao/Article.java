
package dao;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElementRef;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Classe Java pour Article complex type.
 * 
 * <p>Le fragment de schéma suivant indique le contenu attendu figurant dans cette classe.
 * 
 * <pre>
 * &lt;complexType name="Article"&gt;
 *   &lt;complexContent&gt;
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType"&gt;
 *       &lt;sequence&gt;
 *         &lt;element name="dislikes" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/&gt;
 *         &lt;element name="likes" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/&gt;
 *         &lt;element name="num" type="{http://www.w3.org/2001/XMLSchema}int" minOccurs="0"/&gt;
 *         &lt;element name="text" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *         &lt;element name="title" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/&gt;
 *       &lt;/sequence&gt;
 *     &lt;/restriction&gt;
 *   &lt;/complexContent&gt;
 * &lt;/complexType&gt;
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "Article", namespace = "http://schemas.datacontract.org/2004/07/InfosWCFService", propOrder = {
    "dislikes",
    "likes",
    "num",
    "text",
    "title"
})
public class Article {

    protected Integer dislikes;
    protected Integer likes;
    protected Integer num;
    @XmlElementRef(name = "text", namespace = "http://schemas.datacontract.org/2004/07/InfosWCFService", type = JAXBElement.class, required = false)
    protected JAXBElement<String> text;
    @XmlElementRef(name = "title", namespace = "http://schemas.datacontract.org/2004/07/InfosWCFService", type = JAXBElement.class, required = false)
    protected JAXBElement<String> title;

    /**
     * Obtient la valeur de la propriété dislikes.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getDislikes() {
        return dislikes;
    }

    /**
     * Définit la valeur de la propriété dislikes.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setDislikes(Integer value) {
        this.dislikes = value;
    }

    /**
     * Obtient la valeur de la propriété likes.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getLikes() {
        return likes;
    }

    /**
     * Définit la valeur de la propriété likes.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setLikes(Integer value) {
        this.likes = value;
    }

    /**
     * Obtient la valeur de la propriété num.
     * 
     * @return
     *     possible object is
     *     {@link Integer }
     *     
     */
    public Integer getNum() {
        return num;
    }

    /**
     * Définit la valeur de la propriété num.
     * 
     * @param value
     *     allowed object is
     *     {@link Integer }
     *     
     */
    public void setNum(Integer value) {
        this.num = value;
    }

    /**
     * Obtient la valeur de la propriété text.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getText() {
        return text;
    }

    /**
     * Définit la valeur de la propriété text.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setText(JAXBElement<String> value) {
        this.text = value;
    }

    /**
     * Obtient la valeur de la propriété title.
     * 
     * @return
     *     possible object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public JAXBElement<String> getTitle() {
        return title;
    }

    /**
     * Définit la valeur de la propriété title.
     * 
     * @param value
     *     allowed object is
     *     {@link JAXBElement }{@code <}{@link String }{@code >}
     *     
     */
    public void setTitle(JAXBElement<String> value) {
        this.title = value;
    }

}
