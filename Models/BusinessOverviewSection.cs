using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessOverviewSection")]
public class BusinessOverviewSection
{
    [XmlElement("BusinessOverviewRecord")]
    public List<BusinessOverviewRecord> BusinessOverviewRecord { get; set; }

}