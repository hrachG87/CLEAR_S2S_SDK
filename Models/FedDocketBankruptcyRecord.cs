using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FedDocketBankruptcyRecord")]
public class FedDocketBankruptcyRecord
{
    [XmlElement("SummaryInfo")]
    public CourtSummaryInfo SummaryInfo { get; set; }

    [XmlElement("Creditor")]
    public List<Creditor> Creditor { get; set; }

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

    [XmlElement("CaseDocketID")]
    public List<string> CaseDocketID { get; set; }

    [XmlElement("CaseTitle")]
    public List<string> CaseTitle { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("DocketEntries")]
    public List<DocketEntries> DocketEntries { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}
}