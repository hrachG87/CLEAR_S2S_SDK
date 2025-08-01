using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PhoneListingSection")]
public class PhoneListingSection
{
    [XmlElement("PhoneListingRecord")]
    public List<PhoneListingRecord> PhoneListingRecord { get; set; }
}
