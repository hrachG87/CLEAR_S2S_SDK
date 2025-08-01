using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EmailInfo")]
public class EmailInfo
{
    [XmlElement("EmailAddress")]
    public PersonProfile EmailAddress { get; set; }

    [XmlElement("SourceInfo")]
    public SourceInfo SourceInfo { get; set; }
}
