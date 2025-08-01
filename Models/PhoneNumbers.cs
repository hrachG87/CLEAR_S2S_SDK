using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PhoneNumbers")]
public class PhoneNumbers
{
    [XmlElement("OfficePhone")]
    public string OfficePhone { get; set; }

    [XmlElement("MobilePhone")]
    public string MobilePhone { get; set; }

    [XmlElement("HeadquartersPhone")]
    public string HeadquartersPhone { get; set; }

}