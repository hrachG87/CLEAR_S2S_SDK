using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessReportNewsRecord")]
public class BusinessReportNewsRecord
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }

}
}