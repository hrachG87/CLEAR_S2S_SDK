using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("OtherSSNRecord")]
public class OtherSSNRecord
{
    [XmlElement("PersonInfo")]
    public PersonReportPersonInfo PersonInfo { get; set; }

    [XmlElement("SourceInfo")]
    public SourceInfo SourceInfo { get; set; }
}
