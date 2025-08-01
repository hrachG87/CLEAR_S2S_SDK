using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PeopleAddress")]
public class PeopleAddress
{
    [XmlElement("Street")]
    public string Street { get; set; }

    [XmlElement("CityStateZip")]
    public string CityStateZip { get; set; }

    [XmlElement("Phone")]
    public List<string> Phone { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }
}
