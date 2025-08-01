using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CourtDataAKAInfo")]
public class CourtDataAKAInfo
{
    [XmlElement("TypeOfAKA")]
    public string TypeOfAKA { get; set; }

    [XmlElement("AKANumLabel")]
    public string AKANumLabel { get; set; }

    [XmlElement("AKANumber")]
    public string AKANumber { get; set; }

    [XmlElement("AKATypeLabel")]
    public string AKATypeLabel { get; set; }

    [XmlElement("AKAValue")]
    public string AKAValue { get; set; }

    [XmlElement("AKAName")]
    public List<PersonName> AKAName { get; set; }
}
