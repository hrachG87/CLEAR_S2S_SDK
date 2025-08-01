using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CIDCInternationalSearchRecords")]
public class CIDCInternationalSearchRecords
{
    [XmlElement("SearchRecord")]
    public List<CIDCInternationalSearchRecord> SearchRecord { get; set; }
}
