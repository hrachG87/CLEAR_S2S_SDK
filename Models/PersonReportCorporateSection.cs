using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportCorporateSection")]
public class PersonReportCorporateSection
{
    [XmlElement("CorporateRecord")]
    public List<CorporateRecord> CorporateRecord { get; set; }

}