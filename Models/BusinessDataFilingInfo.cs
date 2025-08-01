using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessDataFilingInfo")]
public class BusinessDataFilingInfo
{
    [XmlElement("BusinessType")]
    public List<string> BusinessType { get; set; }

    [XmlElement("FilingDate")]
    public string FilingDate { get; set; }

    [XmlElement("FilingNumber")]
    public string FilingNumber { get; set; }

}