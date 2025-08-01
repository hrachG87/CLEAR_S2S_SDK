using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PoBoxListedAsAddressDetails")]
public class PoBoxListedAsAddressDetails
{
    [XmlElement("Address")]
    public EidvBusinessSearchAddress Address { get; set; }

}