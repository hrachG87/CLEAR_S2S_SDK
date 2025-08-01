using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CanadianPhoneRecord")]
public class CanadianPhoneRecord
{
    [XmlElement("PersonInfo")]
    public PersonInfo PersonInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
