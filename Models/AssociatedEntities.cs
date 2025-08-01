using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AssociatedEntities")]
public class AssociatedEntities
{
    [XmlElement("EntityFilingDate")]
    public string EntityFilingDate { get; set; }

    [XmlElement("EntityFilingNumber")]
    public string EntityFilingNumber { get; set; }

    [XmlElement("EntityJurisState")]
    public string EntityJurisState { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }
}
