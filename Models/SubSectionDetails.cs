using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SubSectionDetails")]
public class SubSectionDetails
{
    [XmlElement("categoryInfo")]
    public List<RIPersonReportCategoryInfo> categoryInfo { get; set; }

}
}