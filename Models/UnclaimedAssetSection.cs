using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("UnclaimedAssetSection")]
public class UnclaimedAssetSection
{
    [XmlElement("UnclaimedAssetRecord")]
    public List<UnclaimedAssetRecord> UnclaimedAssetRecord { get; set; }
}
