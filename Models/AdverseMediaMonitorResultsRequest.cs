using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaMonitorResultsRequest")]
public class AdverseMediaMonitorResultsRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("NewResults")]
    public bool NewResults { get; set; }

    [XmlElement("ResultsOptions")]
    public ResultsOptions ResultsOptions { get; set; }

}
}