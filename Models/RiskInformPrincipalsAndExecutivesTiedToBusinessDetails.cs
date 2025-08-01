using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPrincipalsAndExecutivesTiedToBusinessDetails")]
public class RiskInformPrincipalsAndExecutivesTiedToBusinessDetails
{
    [XmlElement("principalsExecutivesTiedToBusinessRecord")]
    public PrincipalsExecutivesTiedToBusinessRecord principalsExecutivesTiedToBusinessRecord { get; set; }

}
}