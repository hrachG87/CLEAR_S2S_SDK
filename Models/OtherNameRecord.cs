using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OtherNameRecord")]
public class OtherNameRecord
{
    [XmlElement("PersonInfo")]
    public PersonReportPersonInfo PersonInfo { get; set; }

}
}