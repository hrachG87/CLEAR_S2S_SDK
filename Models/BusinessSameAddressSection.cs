using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessSameAddressSection")]
public class BusinessSameAddressSection
{
    [XmlElement("BusinessSameAddressRecord")]
    public List<BusinessSameAddressRecord> BusinessSameAddressRecord { get; set; }
}
