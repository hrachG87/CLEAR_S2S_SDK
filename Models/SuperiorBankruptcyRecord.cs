using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SuperiorBankruptcyRecord")]
public class SuperiorBankruptcyRecord
{
    [XmlElement("Debtor")]
    public List<Debtor> Debtor { get; set; }

    [XmlElement("FilingInfo")]
    public CourtDataFilingInfo FilingInfo { get; set; }

    [XmlElement("Judge")]
    public List<string> Judge { get; set; }

    [XmlElement("OtherParty")]
    public List<CourtPartyInfo> OtherParty { get; set; }

    [XmlElement("Scheduled341")]
    public List<Scheduled341> Scheduled341 { get; set; }

    [XmlElement("Trustee")]
    public List<Trustee> Trustee { get; set; }

    [XmlElement("CaseCategory")]
    public List<string> CaseCategory { get; set; }

    [XmlElement("CaseTitle")]
    public string CaseTitle { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}
}