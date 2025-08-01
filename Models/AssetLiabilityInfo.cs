using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AssetLiabilityInfo")]
public class AssetLiabilityInfo
{
    [XmlElement("OtherAssets")]
    public string OtherAssets { get; set; }

    [XmlElement("OtherLiability")]
    public string OtherLiability { get; set; }

    [XmlElement("ScheduledDate")]
    public string ScheduledDate { get; set; }

    [XmlElement("SecuredExemptAssets")]
    public string SecuredExemptAssets { get; set; }

    [XmlElement("SecuredLiability")]
    public string SecuredLiability { get; set; }

    [XmlElement("TotalAssets")]
    public string TotalAssets { get; set; }

    [XmlElement("TotalLiability")]
    public string TotalLiability { get; set; }

    [XmlElement("UnsecuredLiability")]
    public string UnsecuredLiability { get; set; }
}
