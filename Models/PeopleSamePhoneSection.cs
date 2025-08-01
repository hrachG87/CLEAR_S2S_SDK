using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PeopleSamePhoneSection")]
public class PeopleSamePhoneSection
{
    [XmlElement("PeopleSamePhoneRecord")]
    public List<PeopleSamePhoneRecord> PeopleSamePhoneRecord { get; set; }

}