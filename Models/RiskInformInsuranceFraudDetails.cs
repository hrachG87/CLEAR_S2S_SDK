using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformInsuranceFraudDetails")]
public class RiskInformInsuranceFraudDetails
{
    [XmlElement("insuranceFraudRecord")]
    public CriminalRecordInfo insuranceFraudRecord { get; set; }

}
}