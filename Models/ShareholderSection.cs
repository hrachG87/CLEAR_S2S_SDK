using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ShareholderSection")]
public class ShareholderSection
{
    [XmlElement("ShareholderRecord")]
    public List<ShareholderRecord> ShareholderRecord { get; set; }

}
}