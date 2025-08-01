using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FundamentalRatiosSection")]
public class FundamentalRatiosSection
{
    [XmlElement("FundamentalRatiosRecord")]
    public List<FundamentalRatiosRecord> FundamentalRatiosRecord { get; set; }

}
}