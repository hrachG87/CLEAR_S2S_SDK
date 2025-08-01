using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LitigiousIndividual")]
public class LitigiousIndividual
{
    [XmlElement("TotalLitigiousActivities")]
    public RiskFlagInfo TotalLitigiousActivities { get; set; }

    [XmlElement("TotalLawsuitsAsPlaintiff")]
    public RiskFlagInfo TotalLawsuitsAsPlaintiff { get; set; }

    [XmlElement("TotalDockets")]
    public RiskFlagInfo TotalDockets { get; set; }

}
}