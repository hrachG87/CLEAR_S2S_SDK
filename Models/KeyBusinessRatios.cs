using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("KeyBusinessRatios")]
public class KeyBusinessRatios
{
    [XmlElement("FirstBusinessRatios")]
    public RatioHeaders FirstBusinessRatios { get; set; }

    [XmlElement("ContinuationBusinessRatios")]
    public RatioHeaders ContinuationBusinessRatios { get; set; }

    [XmlElement("Notes")]
    public BusinessNoteInfo Notes { get; set; }
}
