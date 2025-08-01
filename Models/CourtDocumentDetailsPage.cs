using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtDocumentDetailsPage")]
public class CourtDocumentDetailsPage
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("StartPage")]
    public int StartPage { get; set; }

    [XmlElement("EndPage")]
    public int EndPage { get; set; }

    [XmlElement("TotalPages")]
    public int TotalPages { get; set; }

    [XmlElement("ResultGroup")]
    public List<CourtSearchResultsGroup> ResultGroup { get; set; }

}
}