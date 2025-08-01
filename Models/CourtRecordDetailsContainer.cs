using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CourtRecordDetailsContainer")]
public class CourtRecordDetailsContainer
{
    [XmlElement("CourtResponseDetail")]
    public CourtResponseDetail CourtResponseDetail { get; set; }
}
