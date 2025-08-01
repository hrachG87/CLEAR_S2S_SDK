using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CourtDateInfo")]
public class CourtDateInfo
{
    [XmlElement("NextCourtDate")]
    public string NextCourtDate { get; set; }

    [XmlElement("NextCourtTime")]
    public string NextCourtTime { get; set; }
}
