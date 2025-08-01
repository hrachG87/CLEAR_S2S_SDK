using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CorpOfficeSecondaryAddress")]
public class CorpOfficeSecondaryAddress
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("HeadquarterLocation")]
    public string HeadquarterLocation { get; set; }

}