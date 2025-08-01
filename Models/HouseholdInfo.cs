using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("HouseholdInfo")]
public class HouseholdInfo
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }

}