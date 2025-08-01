using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtDataCaseFiling")]
public class CourtDataCaseFiling
{
    [XmlElement("DocumentFileID")]
    public string DocumentFileID { get; set; }

    [XmlElement("DocumentFiledDate")]
    public string DocumentFiledDate { get; set; }

}
}