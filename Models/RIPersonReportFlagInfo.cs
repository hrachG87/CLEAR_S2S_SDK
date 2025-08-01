using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonReportFlagInfo")]
public class RIPersonReportFlagInfo
{
    [XmlElement("FlagName")]
    public string FlagName { get; set; }

    [XmlElement("FlagDescription")]
    public string FlagDescription { get; set; }

    [XmlElement("FlagScore")]
    public string FlagScore { get; set; }

}
}