using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalPleaInfo")]
public class CriminalPleaInfo
{
    [XmlElement("ChangedPlea")]
    public string ChangedPlea { get; set; }

    [XmlElement("OriginalPlea")]
    public string OriginalPlea { get; set; }

    [XmlElement("PleaDate")]
    public string PleaDate { get; set; }

    [XmlElement("PleaWithdrawDate")]
    public string PleaWithdrawDate { get; set; }
}
