using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("LicenseDominantValues")]
public class LicenseDominantValues
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("LicenseInfo")]
    public LicenseResultsInfo LicenseInfo { get; set; }
}
