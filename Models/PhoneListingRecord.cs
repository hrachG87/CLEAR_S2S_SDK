using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PhoneListingRecord")]
public class PhoneListingRecord
{
    [XmlElement("SubjectAddress")]
    public CommonDataAddress SubjectAddress { get; set; }

    [XmlElement("PhoneListingInfo")]
    public List<PersonReportAddressInfo> PhoneListingInfo { get; set; }
}
