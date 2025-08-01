using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OtherProviderInfo")]
public class OtherProviderInfo
{
    [XmlElement("IssuerName")]
    public string IssuerName { get; set; }

    [XmlElement("TypeOfIssuer")]
    public string TypeOfIssuer { get; set; }

    [XmlElement("IDState")]
    public string IDState { get; set; }

    [XmlElement("IDNumber")]
    public string IDNumber { get; set; }

}