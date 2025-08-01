using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PhoneDatasources")]
public class PhoneDatasources
{
    [XmlElement("ReversePhoneLookup")]
    public string ReversePhoneLookup { get; set; }

    [XmlElement("PublicRecordPhones")]
    public string PublicRecordPhones { get; set; }

    [XmlElement("PhoneAttributes")]
    public string PhoneAttributes { get; set; }

}