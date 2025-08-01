using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyReportMarijuanaRelatedBusinessesSection")]
public class CompanyReportMarijuanaRelatedBusinessesSection
{
    [XmlElement("MarijuanaRelatedBusinessRecord")]
    public List<MarijuanaRelatedBusinessRecord> MarijuanaRelatedBusinessRecord { get; set; }

}