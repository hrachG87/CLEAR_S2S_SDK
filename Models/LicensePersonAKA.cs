using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LicensePersonAKA")]
public class LicensePersonAKA
{
    [XmlElement("PersonInfo")]
    public LicensePersonInfo PersonInfo { get; set; }

    [XmlElement("TypeOfAKA")]
    public string TypeOfAKA { get; set; }

}