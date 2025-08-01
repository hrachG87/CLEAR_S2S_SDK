using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("LicenseDominantValuesContainer")]
public class LicenseDominantValuesContainer
{
    [XmlElement("licenseDominantValues")]
    public LicenseDominantValues licenseDominantValues { get; set; }
}
