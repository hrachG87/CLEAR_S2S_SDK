using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonReportScore")]
public class RIPersonReportScore
{
    [XmlElement("riskInformScoreRecord")]
    public RIPersonReportScoreRecord riskInformScoreRecord { get; set; }

}
}