using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanySources")]
public class CompanySources
{
    [XmlElement("SourceName")]
    public string SourceName { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}