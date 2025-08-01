using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PhoneUserCriteria")]
public class PhoneUserCriteria
{
    [XmlElement("PhoneCriteria")]
    public PhoneCriteria PhoneCriteria { get; set; }
}
