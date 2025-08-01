using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("NationalClassInfo")]
public class NationalClassInfo
{
    [XmlElement("NationalClass")]
    public string NationalClass { get; set; }

    [XmlElement("NationalSubClass")]
    public string NationalSubClass { get; set; }
}
