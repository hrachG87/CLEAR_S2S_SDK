using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskFlagSICInfo")]
public class RiskFlagSICInfo
{
    [XmlElement("SICCode")]
    public string SICCode { get; set; }

    [XmlElement("SICDesc")]
    public string SICDesc { get; set; }

    [XmlElement("SICExt")]
    public string SICExt { get; set; }

    [XmlElement("NAICSCode")]
    public string NAICSCode { get; set; }

    [XmlElement("NAICSDesc")]
    public string NAICSDesc { get; set; }

}