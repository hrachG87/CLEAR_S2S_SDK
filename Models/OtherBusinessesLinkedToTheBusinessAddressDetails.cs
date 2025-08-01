using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("OtherBusinessesLinkedToTheBusinessAddressDetails")]
public class OtherBusinessesLinkedToTheBusinessAddressDetails
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("Address")]
    public EidvBusinessSearchAddress Address { get; set; }
}
