using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FlagsSearchSources")]
public class FlagsSearchSources
{
    [XmlElement("SourceName")]
    public string SourceName { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}