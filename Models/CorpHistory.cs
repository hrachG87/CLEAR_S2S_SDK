using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CorpHistory")]
public class CorpHistory
{
    [XmlElement("AmendFileDate")]
    public string AmendFileDate { get; set; }

    [XmlElement("HistoryCode")]
    public string HistoryCode { get; set; }

    [XmlElement("HistoryDesc")]
    public string HistoryDesc { get; set; }

}
}