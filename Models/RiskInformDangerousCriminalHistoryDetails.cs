using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformDangerousCriminalHistoryDetails")]
public class RiskInformDangerousCriminalHistoryDetails
{
    [XmlElement("dangerousHistoryRecord")]
    public CriminalRecordInfo dangerousHistoryRecord { get; set; }

}
}