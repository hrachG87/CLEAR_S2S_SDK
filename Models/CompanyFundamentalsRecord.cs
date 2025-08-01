using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyFundamentalsRecord")]
public class CompanyFundamentalsRecord
{
    [XmlElement("CompanyProfileRecord")]
    public CompanyProfileRecord CompanyProfileRecord { get; set; }

    [XmlElement("AnnualFinancialsRecord")]
    public AnnualFinancialsRecord AnnualFinancialsRecord { get; set; }

    [XmlElement("ExecutiveOfficersRecord")]
    public ExecutiveOfficersRecord ExecutiveOfficersRecord { get; set; }

    [XmlElement("FundamentalRatiosRecord")]
    public FundamentalRatiosRecord FundamentalRatiosRecord { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}
}