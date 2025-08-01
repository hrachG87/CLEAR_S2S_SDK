using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdditionalCriteria")]
public class AdditionalCriteria
{
    [XmlElement("Phone")]
    public List<string> Phone { get; set; }

    [XmlElement("EmailAddress")]
    public List<string> EmailAddress { get; set; }

    [XmlElement("Username")]
    public List<string> Username { get; set; }

    [XmlElement("School")]
    public List<string> School { get; set; }

    [XmlElement("Associate")]
    public List<AssociateNameInfo> Associate { get; set; }
}
