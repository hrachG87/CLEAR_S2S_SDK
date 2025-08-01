using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MortgageBasicInfo")]
public class MortgageBasicInfo
{
    [XmlElement("MortgageAmount")]
    public string MortgageAmount { get; set; }

    [XmlElement("TypeOfDeedMortgage")]
    public string TypeOfDeedMortgage { get; set; }

    [XmlElement("TypeOfMortgage")]
    public string TypeOfMortgage { get; set; }

}
}