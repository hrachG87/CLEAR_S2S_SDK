using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SupervisorInfo")]
public class SupervisorInfo
{
    [XmlElement("PersonLicense")]
    public string PersonLicense { get; set; }

    [XmlElement("SupervisorID")]
    public string SupervisorID { get; set; }

    [XmlElement("TypeOfLicense")]
    public string TypeOfLicense { get; set; }

    [XmlElement("PersonName")]
    public List<PersonName> PersonName { get; set; }
}
