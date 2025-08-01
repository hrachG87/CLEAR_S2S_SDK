using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonDominantValuesContainer")]
public class PersonDominantValuesContainer
{
    [XmlElement("PersonDominantValues")]
    public PersonDominantValues PersonDominantValues { get; set; }

}