using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WorldcheckDocumentSearchRequest")]
public class WorldcheckDocumentSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public WorldcheckDocumentUserCriteria Criteria { get; set; }

    [XmlElement("Datasources")]
    public WorldcheckDocumentDataSources Datasources { get; set; }

}
}