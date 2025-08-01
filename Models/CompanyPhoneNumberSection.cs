using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyPhoneNumberSection")]
public class CompanyPhoneNumberSection
{
    [XmlElement("CompanyPhoneRecord")]
    public List<CompanyPhoneRecord> CompanyPhoneRecord { get; set; }
}
