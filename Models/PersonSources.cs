using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonSources")]
public class PersonSources
{
    [XmlElement("SourceName")]
    public string SourceName { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}