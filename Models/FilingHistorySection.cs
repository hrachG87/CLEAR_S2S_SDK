using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("FilingHistorySection")]
public class FilingHistorySection
{
    [XmlElement("FilingHistoryRecord")]
    public List<FilingHistoryRecord> FilingHistoryRecord { get; set; }
}
