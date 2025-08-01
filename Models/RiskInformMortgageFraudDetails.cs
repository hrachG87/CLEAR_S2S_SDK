using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformMortgageFraudDetails")]
public class RiskInformMortgageFraudDetails
{
    [XmlElement("mortgageFraudRecord")]
    public CriminalRecordInfo mortgageFraudRecord { get; set; }

}
}