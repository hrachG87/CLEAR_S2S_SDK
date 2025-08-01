using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalPersonAKA")]
public class CriminalPersonAKA
{
    [XmlElement("AKADateOfBirth")]
    public string AKADateOfBirth { get; set; }

    [XmlElement("AKAPersonName")]
    public PersonName AKAPersonName { get; set; }

    [XmlElement("AKANickName")]
    public List<string> AKANickName { get; set; }

}