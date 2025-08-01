using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PhoneCriteria")]
public class PhoneCriteria
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("PersonName")]
    public PhoneNameCriteria PersonName { get; set; }

    [XmlElement("Address")]
    public PhoneAddressCriteria Address { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("PhoneCountryCode")]
    public string PhoneCountryCode { get; set; }

    [XmlElement("DocGuid")]
    public string DocGuid { get; set; }
}
