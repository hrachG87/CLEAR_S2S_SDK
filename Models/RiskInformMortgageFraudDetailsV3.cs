using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformMortgageFraudDetailsV3")]
public class RiskInformMortgageFraudDetailsV3
{
    [XmlElement("mortgageFraudRecord")]
    public CriminalRecordInfoV3 mortgageFraudRecord { get; set; }

}
}