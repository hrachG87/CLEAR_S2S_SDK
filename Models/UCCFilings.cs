using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UCCFilings")]
public class UCCFilings
{
    [XmlElement("CompanyIsDebtor")]
    public BusinessRiskFlagInfo CompanyIsDebtor { get; set; }

    [XmlElement("UCCFilingsFlag")]
    public BusinessRiskFlagInfo UCCFilingsFlag { get; set; }

}
}