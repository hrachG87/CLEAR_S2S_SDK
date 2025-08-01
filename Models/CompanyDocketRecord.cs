using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyDocketRecord")]
public class CompanyDocketRecord
{
    [XmlElement("DocketInfo")]
    public List<DocketInfo> DocketInfo { get; set; }

}
}