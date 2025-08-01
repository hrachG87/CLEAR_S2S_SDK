using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SanctionOverride")]
public class SanctionOverride
{
    [XmlElement("SanctionName")]
    public string SanctionName { get; set; }

    [XmlElement("Relevancy")]
    public int Relevancy { get; set; }

    [XmlElement("Exclude")]
    public bool Exclude { get; set; }

}