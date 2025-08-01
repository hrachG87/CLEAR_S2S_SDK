using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CorpOfficerInfo")]
public class CorpOfficerInfo
{
    [XmlElement("CorpOfficerSecondaryAddress")]
    public CorpOfficeSecondaryAddress CorpOfficerSecondaryAddress { get; set; }

    [XmlElement("CorpOfficerAddress")]
    public CommonDataAddress CorpOfficerAddress { get; set; }

    [XmlElement("NameType")]
    public string NameType { get; set; }

    [XmlElement("NameTypeDesc")]
    public string NameTypeDesc { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }
}
