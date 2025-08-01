using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessSingleSourceTiedToEntity")]
public class BusinessSingleSourceTiedToEntity
{
    [XmlElement("SingleSourceTiedToEntityIndicator")]
    public string SingleSourceTiedToEntityIndicator { get; set; }

    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("SingleSourceTiedToEntityDetails")]
    public SingleSourceTiedToEntityDetails SingleSourceTiedToEntityDetails { get; set; }
}
