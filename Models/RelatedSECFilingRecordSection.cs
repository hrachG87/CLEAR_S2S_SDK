using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RelatedSECFilingRecordSection")]
public class RelatedSECFilingRecordSection
{
    [XmlElement("RelatedSECFilingRecord")]
    public List<RelatedSECFilingRecord> RelatedSECFilingRecord { get; set; }

}