using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DistrictCourtDocket")]
public class DistrictCourtDocket
{
    [XmlElement("CaseSubcategory")]
    public string CaseSubcategory { get; set; }

    [XmlElement("DocketNumber")]
    public string DocketNumber { get; set; }

}
}