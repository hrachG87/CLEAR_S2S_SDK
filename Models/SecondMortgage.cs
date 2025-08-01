using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SecondMortgage")]
public class SecondMortgage
{
    [XmlElement("MortgageBasicInfo")]
    public MortgageBasicInfo MortgageBasicInfo { get; set; }

}
}