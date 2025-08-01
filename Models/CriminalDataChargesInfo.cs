using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalDataChargesInfo")]
public class CriminalDataChargesInfo
{
    [XmlElement("ChargesDescription")]
    public string ChargesDescription { get; set; }

    [XmlElement("NumberOfCounts")]
    public string NumberOfCounts { get; set; }

    [XmlElement("StatuteViolated")]
    public string StatuteViolated { get; set; }

    [XmlElement("NCICCode")]
    public string NCICCode { get; set; }
}
