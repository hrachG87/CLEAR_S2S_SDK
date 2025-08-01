using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ExecutiveOfficersRecord")]
public class ExecutiveOfficersRecord
{
    [XmlElement("Executives")]
    public List<ExecutiveInfo> Executives { get; set; }

    [XmlElement("BusinessContacts")]
    public List<BusinessContacts> BusinessContacts { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }
}
