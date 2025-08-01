using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EidvSearchRecords")]
public class EidvSearchRecords
{
    [XmlElement("SearchRecord")]
    public List<EidvSearchRecord> SearchRecord { get; set; }

}