using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessSamePhoneRecord")]
public class BusinessSamePhoneRecord
{
    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("CompanyNames")]
    public List<CompanyNames> CompanyNames { get; set; }
}
