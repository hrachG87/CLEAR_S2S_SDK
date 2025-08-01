using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformCriminalHistoryDetails")]
public class RiskInformCriminalHistoryDetails
{
    [XmlElement("criminalHistoryRecord")]
    public CriminalRecordInfo criminalHistoryRecord { get; set; }

}
}