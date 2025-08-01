using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RelatedSECFilingRecord")]
public class RelatedSECFilingRecord
{
    [XmlElement("RelatedSECFinancialFilings")]
    public List<SECInfo> RelatedSECFinancialFilings { get; set; }
}
