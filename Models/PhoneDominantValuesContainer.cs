using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PhoneDominantValuesContainer")]
public class PhoneDominantValuesContainer
{
    [XmlElement("phoneDominantValues")]
    public PhoneDominantValues phoneDominantValues { get; set; }
}
