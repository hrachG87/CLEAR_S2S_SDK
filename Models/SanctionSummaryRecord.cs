using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SanctionSummaryRecord")]
public class SanctionSummaryRecord
{
    [XmlElement("Number")]
    public int Number { get; set; }

    [XmlElement("SanctionType")]
    public string SanctionType { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("URL")]
    public string URL { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

}
}