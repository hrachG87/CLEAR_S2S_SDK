using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PeopleSameAddressSection")]
public class PeopleSameAddressSection
{
    [XmlElement("PeopleSameAddressRecord")]
    public List<PeopleSameAddressRecord> PeopleSameAddressRecord { get; set; }

}