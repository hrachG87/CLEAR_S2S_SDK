using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SearchRecords")]
public class SearchRecords
{
    [XmlElement("SearchRecord")]
    public List<SearchRecord> SearchRecord { get; set; }
}
