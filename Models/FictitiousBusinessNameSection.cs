using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("FictitiousBusinessNameSection")]
public class FictitiousBusinessNameSection
{
    [XmlElement("FictitiousBusinessRecord")]
    public List<FictitiousBusinessRecord> FictitiousBusinessRecord { get; set; }
}
