using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OtherSSNRecord")]
public class OtherSSNRecord
{
    [XmlElement("PersonInfo")]
    public PersonReportPersonInfo PersonInfo { get; set; }

    [XmlElement("SourceInfo")]
    public SourceInfo SourceInfo { get; set; }

}
}