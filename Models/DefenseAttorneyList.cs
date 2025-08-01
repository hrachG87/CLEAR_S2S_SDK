using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DefenseAttorneyList")]
public class DefenseAttorneyList
{
    [XmlElement("TypeOfDefenseUsed")]
    public string TypeOfDefenseUsed { get; set; }

    [XmlElement("AttorneyInfo")]
    public AttorneyInfo AttorneyInfo { get; set; }

    [XmlElement("AttorneyAddress")]
    public CommonDataAddress AttorneyAddress { get; set; }
}
