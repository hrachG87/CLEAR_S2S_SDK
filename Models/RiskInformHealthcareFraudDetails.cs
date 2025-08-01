using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformHealthcareFraudDetails")]
public class RiskInformHealthcareFraudDetails
{
    [XmlElement("healthcareFraudRecord")]
    public CriminalRecordInfo healthcareFraudRecord { get; set; }

}
}