using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformAddressDetails")]
public class RiskInformAddressDetails
{
    [XmlElement("AddressRecord")]
    public RIBusinessReportAddressRecord AddressRecord { get; set; }
}
