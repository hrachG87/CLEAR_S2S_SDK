using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIPersonReportAddressDetails")]
public class RIPersonReportAddressDetails
{
    [XmlElement("addressRecord")]
    public AddressRecord addressRecord { get; set; }

}