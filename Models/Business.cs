using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Business")]
public class Business
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }
}
