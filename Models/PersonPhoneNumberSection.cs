using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonPhoneNumberSection")]
public class PersonPhoneNumberSection
{
    [XmlElement("PhoneNumberRecord")]
    public List<PhoneNumberRecord> PhoneNumberRecord { get; set; }
}
