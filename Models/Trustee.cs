using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Trustee")]
public class Trustee
{
    [XmlElement("PartyInfo")]
    public CourtPartyInfo PartyInfo { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

}