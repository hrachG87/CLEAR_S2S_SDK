using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformTaxFraudDetailsV3")]
public class RiskInformTaxFraudDetailsV3
{
    [XmlElement("taxFraudRecord")]
    public CriminalRecordInfoV3 taxFraudRecord { get; set; }

}
}