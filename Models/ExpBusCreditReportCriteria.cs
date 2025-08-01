using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ExpBusCreditReportCriteria")]
public class ExpBusCreditReportCriteria
{
    [XmlElement("GroupID")]
    public string GroupID { get; set; }

}
}