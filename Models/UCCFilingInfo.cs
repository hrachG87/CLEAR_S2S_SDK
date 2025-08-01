using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("UCCFilingInfo")]
public class UCCFilingInfo
{
    [XmlElement("FilingStmtInfo")]
    public List<FilingStmtInfo> FilingStmtInfo { get; set; }

    [XmlElement("Debtor")]
    public List<BusinessPartyInfo> Debtor { get; set; }

    [XmlElement("SecuredParty")]
    public List<BusinessPartyInfo> SecuredParty { get; set; }

    [XmlElement("Assignee")]
    public List<BusinessPartyInfo> Assignee { get; set; }

    [XmlElement("Assignor")]
    public List<BusinessPartyInfo> Assignor { get; set; }

    [XmlElement("RealEstateInfo")]
    public BusinessRealEstateInfo RealEstateInfo { get; set; }

    [XmlElement("CollateralInfo")]
    public List<CollateralInfo> CollateralInfo { get; set; }

    [XmlElement("FilingOfficeStmt")]
    public FilingOfficeStmt FilingOfficeStmt { get; set; }

    [XmlElement("RelatedFilingInfo")]
    public List<RelatedFilingInfo> RelatedFilingInfo { get; set; }

}