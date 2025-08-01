using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformGovProcurementFraudDetails")]
public class RiskInformGovProcurementFraudDetails
{
    [XmlElement("govProcurementFraudRecord")]
    public CriminalRecordInfo govProcurementFraudRecord { get; set; }

}
}