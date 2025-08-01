using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("InquiriesRecord")]
public class InquiriesRecord
{
    [XmlElement("BusinessInquiries")]
    public BusinessInquiries BusinessInquiries { get; set; }

}
}