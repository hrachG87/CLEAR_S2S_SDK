using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CorporateLinkageDetail")]
public class CorporateLinkageDetail
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("Location")]
    public Address Location { get; set; }

    [XmlElement("BIN")]
    public string BIN { get; set; }

}