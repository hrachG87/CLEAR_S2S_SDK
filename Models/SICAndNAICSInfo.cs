using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SICAndNAICSInfo")]
public class SICAndNAICSInfo
{
    [XmlElement("PrimarySICCode")]
    public RiskFlagSICInfo PrimarySICCode { get; set; }

    [XmlElement("AdditionalSICCodes")]
    public List<RiskFlagSICInfo> AdditionalSICCodes { get; set; }

    [XmlElement("NAICSCodes")]
    public List<RiskFlagSICInfo> NAICSCodes { get; set; }
}
