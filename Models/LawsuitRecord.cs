using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LawsuitRecord")]
public class LawsuitRecord
{
    [XmlElement("Defendant")]
    public List<Debtor> Defendant { get; set; }

    [XmlElement("Plaintiff")]
    public List<Plaintiff> Plaintiff { get; set; }

    [XmlElement("FilingInfo")]
    public List<CourtDataFilingInfo> FilingInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}
}