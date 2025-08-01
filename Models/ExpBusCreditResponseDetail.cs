using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ExpBusCreditResponseDetail")]
public class ExpBusCreditResponseDetail
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("Street")]
    public string Street { get; set; }

    [XmlElement("City")]
    public string City { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

    [XmlElement("ZipCode")]
    public string ZipCode { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

}