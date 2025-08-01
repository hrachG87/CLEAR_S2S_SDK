using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DECorpReportCriteria")]
public class DECorpReportCriteria
{
    [XmlElement("GroupID")]
    public string GroupID { get; set; }

}
}