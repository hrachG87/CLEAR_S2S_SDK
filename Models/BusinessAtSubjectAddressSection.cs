using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessAtSubjectAddressSection")]
public class BusinessAtSubjectAddressSection
{
    [XmlElement("BusinessAtSubjectAddressRecord")]
    public List<BusinessAtSubjectAddressRecord> BusinessAtSubjectAddressRecord { get; set; }
}
