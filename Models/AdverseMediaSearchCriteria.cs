using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaSearchCriteria")]
public class AdverseMediaSearchCriteria
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("KeyWords")]
    public string KeyWords { get; set; }

    [XmlElement("Scope")]
    public string Scope { get; set; }

    [XmlElement("ArticleDateRange")]
    public AdverseMediaDateOptions ArticleDateRange { get; set; }

    [XmlElement("Translation")]
    public bool Translation { get; set; }

    [XmlElement("DateOfBirth")]
    public string DateOfBirth { get; set; }

    [XmlElement("Location")]
    public string Location { get; set; }

}