using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessSameAddressRecord")]
public class BusinessSameAddressRecord
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("CompanyNames")]
    public List<CompanyNames> CompanyNames { get; set; }

    [XmlElement("DunBradstreetRecord")]
    public DunBradstreetRecord DunBradstreetRecord { get; set; }

    [XmlElement("PhoneRecord")]
    public PhoneRecord PhoneRecord { get; set; }
}
