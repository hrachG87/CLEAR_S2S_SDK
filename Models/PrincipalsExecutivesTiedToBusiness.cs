using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PrincipalsExecutivesTiedToBusiness")]
public class PrincipalsExecutivesTiedToBusiness
{
    [XmlElement("ListOfPrincipalsExecutivesTiedToBusiness")]
    public BusinessRiskFlagInfo ListOfPrincipalsExecutivesTiedToBusiness { get; set; }

}
}