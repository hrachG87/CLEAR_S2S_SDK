using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformBusinessUserCriteria")]
public class RiskInformBusinessUserCriteria
{
    [XmlElement("RiskInformBusinessSearchCriteria")]
    public RiskInformBusinessSearchCriteria RiskInformBusinessSearchCriteria { get; set; }

}
}