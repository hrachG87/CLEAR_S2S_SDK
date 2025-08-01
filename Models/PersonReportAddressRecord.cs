using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonReportAddressRecord")]
public class PersonReportAddressRecord
{
    [XmlElement("AddressInfo")]
    public List<PersonReportAddressInfo> AddressInfo { get; set; }
}
