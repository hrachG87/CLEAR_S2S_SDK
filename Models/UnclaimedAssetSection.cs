using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UnclaimedAssetSection")]
public class UnclaimedAssetSection
{
    [XmlElement("UnclaimedAssetRecord")]
    public List<UnclaimedAssetRecord> UnclaimedAssetRecord { get; set; }

}
}