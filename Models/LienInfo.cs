using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("LienInfo")]
public class LienInfo
{
    [XmlElement("DebtLot")]
    public string DebtLot { get; set; }

    [XmlElement("DebtNumber")]
    public string DebtNumber { get; set; }

    [XmlElement("JudgmentAmount")]
    public string JudgmentAmount { get; set; }

    [XmlElement("SatisfactionDate")]
    public string SatisfactionDate { get; set; }

    [XmlElement("TypeofSatisfaction")]
    public string TypeofSatisfaction { get; set; }

    [XmlElement("SheriffExecutionRequired")]
    public string SheriffExecutionRequired { get; set; }

    [XmlElement("ExpirationDate")]
    public List<string> ExpirationDate { get; set; }

    [XmlElement("CreditorAmount")]
    public string CreditorAmount { get; set; }

    [XmlElement("LienAmount")]
    public string LienAmount { get; set; }

    [XmlElement("LienPrincipalAmount")]
    public string LienPrincipalAmount { get; set; }

    [XmlElement("TaxAmount")]
    public string TaxAmount { get; set; }

    [XmlElement("LienTotalAmount")]
    public string LienTotalAmount { get; set; }

    [XmlElement("TotalAmountPaid")]
    public string TotalAmountPaid { get; set; }

    [XmlElement("TotalCalculatedAmount")]
    public string TotalCalculatedAmount { get; set; }

    [XmlElement("TotalCalculatedAmountPaid")]
    public string TotalCalculatedAmountPaid { get; set; }

    [XmlElement("StatusInfo")]
    public StatusInfo StatusInfo { get; set; }

    [XmlElement("SubjudgmentInfo")]
    public SubjudgmentInfo SubjudgmentInfo { get; set; }
}
