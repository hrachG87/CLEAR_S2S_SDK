using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ReportPermissiblePurpose")]
public class ReportPermissiblePurpose
{
    [XmlElement("GLB")]
    public string GLB { get; set; }

    [XmlElement("DPPA")]
    public string DPPA { get; set; }

    [XmlElement("VOTER")]
    public string VOTER { get; set; }

}
}