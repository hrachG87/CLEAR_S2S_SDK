using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformFinancialCrimesDetails")]
public class RiskInformFinancialCrimesDetails
{
    [XmlElement("financialCrimesRecord")]
    public CriminalRecordInfo financialCrimesRecord { get; set; }

}
}