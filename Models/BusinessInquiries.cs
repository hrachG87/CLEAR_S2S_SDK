using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessInquiries")]
public class BusinessInquiries
{
    [XmlElement("BusinessInquiry")]
    public List<BusinessInquiry> BusinessInquiry { get; set; }

}
}