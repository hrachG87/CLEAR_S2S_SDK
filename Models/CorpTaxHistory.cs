using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CorpTaxHistory")]
public class CorpTaxHistory
{
    [XmlElement("AnnualRptFileDate")]
    public string AnnualRptFileDate { get; set; }

    [XmlElement("FranchiseAmount")]
    public string FranchiseAmount { get; set; }

    [XmlElement("FranchisePaidDate")]
    public string FranchisePaidDate { get; set; }

    [XmlElement("FranchiseStatus")]
    public string FranchiseStatus { get; set; }

    [XmlElement("TaxID")]
    public string TaxID { get; set; }

    [XmlElement("TaxAmount")]
    public string TaxAmount { get; set; }

    [XmlElement("TaxBalance")]
    public string TaxBalance { get; set; }

    [XmlElement("TaxPercentage")]
    public string TaxPercentage { get; set; }

    [XmlElement("TotalTaxes")]
    public string TotalTaxes { get; set; }

}
}