using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportAssociationType")]
public class CompanyReportAssociationType
{
    [XmlElement("TypeOfAssociation")]
    public List<string> TypeOfAssociation { get; set; }

}
}