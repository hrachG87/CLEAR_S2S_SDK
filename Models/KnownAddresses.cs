using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("KnownAddresses")]
public class KnownAddresses
{
    [XmlElement("KnownAddress")]
    public List<KnownAddress> KnownAddress { get; set; }
}
