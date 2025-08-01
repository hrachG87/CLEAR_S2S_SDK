using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonSummaryInfo")]
public class PersonSummaryInfo
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("State")]
    public string State { get; set; }

    [XmlElement("Date")]
    public string Date { get; set; }

    [XmlElement("Type")]
    public string Type { get; set; }

    [XmlElement("Class")]
    public string Class { get; set; }
}
