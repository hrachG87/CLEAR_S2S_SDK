using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LastAddress")]
public class LastAddress
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("DeathResidence")]
    public string DeathResidence { get; set; }

}