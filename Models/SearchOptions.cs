using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SearchOptions")]
public class SearchOptions
{
    [XmlElement("OnlyHeadlineAndLeadPara")]
    public bool OnlyHeadlineAndLeadPara { get; set; }

}
}