using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("KeyNatureOfSuitInfo")]
public class KeyNatureOfSuitInfo
{
    [XmlElement("NatureOfSuitLevel1")]
    public string NatureOfSuitLevel1 { get; set; }

    [XmlElement("NatureOfSuitLevel2")]
    public string NatureOfSuitLevel2 { get; set; }

    [XmlElement("NatureOfSuitLevel3")]
    public string NatureOfSuitLevel3 { get; set; }

    [XmlElement("NatureOfSuitCode")]
    public string NatureOfSuitCode { get; set; }

}