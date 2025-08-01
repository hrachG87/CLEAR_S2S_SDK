using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CourtPersonInfo")]
public class CourtPersonInfo
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }
}
