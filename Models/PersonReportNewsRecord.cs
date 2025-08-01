using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportNewsRecord")]
public class PersonReportNewsRecord
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }

}
}