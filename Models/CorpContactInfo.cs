using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CorpContactInfo")]
public class CorpContactInfo
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("OfficeAddress")]
    public CorpOfficeSecondaryAddress OfficeAddress { get; set; }
}
