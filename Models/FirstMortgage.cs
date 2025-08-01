using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FirstMortgage")]
public class FirstMortgage
{
    [XmlElement("MortgageBasicInfo")]
    public MortgageBasicInfo MortgageBasicInfo { get; set; }

    [XmlElement("MortgageDetailInfo")]
    public MortgageDetailInfo MortgageDetailInfo { get; set; }

}
}