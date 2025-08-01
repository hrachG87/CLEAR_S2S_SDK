using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformGovProcurementFraudDetailsV3")]
public class RiskInformGovProcurementFraudDetailsV3
{
    [XmlElement("govProcurementFraudRecord")]
    public CriminalRecordInfoV3 govProcurementFraudRecord { get; set; }

}
}