using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UnclaimedAssetRecord")]
public class UnclaimedAssetRecord
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("AssetHolder")]
    public string AssetHolder { get; set; }

    [XmlElement("AssetNumber")]
    public string AssetNumber { get; set; }

    [XmlElement("AssetType")]
    public string AssetType { get; set; }

    [XmlElement("AssetValue")]
    public string AssetValue { get; set; }

    [XmlElement("AssetValueText")]
    public string AssetValueText { get; set; }

    [XmlElement("NumberOfShares")]
    public string NumberOfShares { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

}
}