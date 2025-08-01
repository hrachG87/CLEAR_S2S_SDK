using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("InquiriesSection")]
public class InquiriesSection
{
    [XmlElement("InquiriesRecord")]
    public List<InquiriesRecord> InquiriesRecord { get; set; }

}
}