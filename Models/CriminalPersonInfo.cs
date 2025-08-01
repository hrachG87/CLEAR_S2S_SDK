using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalPersonInfo")]
public class CriminalPersonInfo
{
    [XmlElement("PersonName")]
    public List<PersonName> PersonName { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("PersonAKA")]
    public List<CriminalPersonAKA> PersonAKA { get; set; }

    [XmlElement("PersonSSN")]
    public SSNInfo PersonSSN { get; set; }

    [XmlElement("PersonMilitarySummary")]
    public List<CriminalPersonMilitarySummary> PersonMilitarySummary { get; set; }

    [XmlElement("PersonEducation")]
    public List<PersonEducation> PersonEducation { get; set; }

}