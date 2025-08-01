using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIPersonReportSections")]
public class RIPersonReportSections
{
    [XmlElement("section")]
    public List<RIPersonReportSection> section { get; set; }

}