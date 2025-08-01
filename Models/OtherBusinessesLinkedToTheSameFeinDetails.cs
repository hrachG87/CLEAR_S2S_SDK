using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OtherBusinessesLinkedToTheSameFeinDetails")]
public class OtherBusinessesLinkedToTheSameFeinDetails
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("Fein")]
    public string Fein { get; set; }

}