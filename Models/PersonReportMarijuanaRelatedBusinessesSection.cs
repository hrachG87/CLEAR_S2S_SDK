using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportMarijuanaRelatedBusinessesSection")]
public class PersonReportMarijuanaRelatedBusinessesSection
{
    [XmlElement("MarijuanaRelatedBusinessRecord")]
    public List<MarijuanaRelatedBusinessRecord> MarijuanaRelatedBusinessRecord { get; set; }

}