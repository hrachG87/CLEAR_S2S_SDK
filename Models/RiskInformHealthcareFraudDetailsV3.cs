using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformHealthcareFraudDetailsV3")]
public class RiskInformHealthcareFraudDetailsV3
{
    [XmlElement("healthcareFraudRecord")]
    public CriminalRecordInfoV3 healthcareFraudRecord { get; set; }

}
}