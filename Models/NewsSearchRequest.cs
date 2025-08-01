using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("NewsSearchRequest")]
public class NewsSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public NewsCriteria Criteria { get; set; }

    [XmlElement("NewsDatasets")]
    public NewsDatasets NewsDatasets { get; set; }

}
}