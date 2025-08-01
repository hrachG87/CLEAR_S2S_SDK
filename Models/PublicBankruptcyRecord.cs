using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PublicBankruptcyRecord")]
public class PublicBankruptcyRecord
{
    [XmlElement("AssetLiabilityInfo")]
    public List<AssetLiabilityInfo> AssetLiabilityInfo { get; set; }

    [XmlElement("Comments")]
    public List<CommentInfo> Comments { get; set; }

    [XmlElement("Creditor")]
    public List<Creditor> Creditor { get; set; }

    [XmlElement("Debtor")]
    public List<Debtor> Debtor { get; set; }

    [XmlElement("EventHistory")]
    public List<EventHistory> EventHistory { get; set; }

    [XmlElement("FilingInfo")]
    public CourtDataFilingInfo FilingInfo { get; set; }

    [XmlElement("FilingOfficeAddress")]
    public CommonDataAddress FilingOfficeAddress { get; set; }

    [XmlElement("Judge")]
    public string Judge { get; set; }

    [XmlElement("PlanInfo")]
    public PlanInfo PlanInfo { get; set; }

    [XmlElement("Referee")]
    public CourtPartyInfo Referee { get; set; }

    [XmlElement("Scheduled341")]
    public Scheduled341 Scheduled341 { get; set; }

    [XmlElement("Trustee")]
    public Trustee Trustee { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
