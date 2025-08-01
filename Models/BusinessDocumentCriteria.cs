using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessDocumentCriteria")]
public class BusinessDocumentCriteria
{
    [XmlElement("PersonName")]
    public BusinessDocumentNameCriteria PersonName { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("Address")]
    public BusinessDocumentAddressCriteria Address { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("DocGuid")]
    public string DocGuid { get; set; }

    [XmlElement("NPINumber")]
    public string NPINumber { get; set; }
}
