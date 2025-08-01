using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtSearchRequest")]
public class CourtSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public CourtUserCriteria Criteria { get; set; }

    [XmlElement("Datasources")]
    public CourtDatasources Datasources { get; set; }

    [XmlElement("CriminalDatasets")]
    public CriminalDatasets CriminalDatasets { get; set; }

    [XmlElement("CriminalCategories")]
    public CriminalCategories CriminalCategories { get; set; }

}
}