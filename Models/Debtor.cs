using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Debtor")]
public class Debtor
{
    [XmlElement("DebtorOwedAmount")]
    public string DebtorOwedAmount { get; set; }

    [XmlElement("DebtorOccupation")]
    public string DebtorOccupation { get; set; }

    [XmlElement("NumberOfDebtors")]
    public string NumberOfDebtors { get; set; }

    [XmlElement("PartyInfo")]
    public CourtPartyInfo PartyInfo { get; set; }

    [XmlElement("DebtorDescription")]
    public string DebtorDescription { get; set; }

    [XmlElement("DebtorAmount")]
    public List<string> DebtorAmount { get; set; }

    [XmlElement("ObligationInfo")]
    public List<ObligationInfo> ObligationInfo { get; set; }

    [XmlElement("DispositionInfo")]
    public CaseDisposition DispositionInfo { get; set; }

    [XmlElement("DemandAmount")]
    public List<string> DemandAmount { get; set; }

    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("DebtorSignerInfo")]
    public DebtorSignerInfo DebtorSignerInfo { get; set; }

    [XmlElement("TaxID")]
    public string TaxID { get; set; }

    [XmlElement("TypeOfDebtor")]
    public List<string> TypeOfDebtor { get; set; }

    [XmlElement("TypeOfDebtorName")]
    public List<string> TypeOfDebtorName { get; set; }

    [XmlElement("DUNSNumber")]
    public string DUNSNumber { get; set; }

    [XmlElement("SSNInfo")]
    public List<SSNInfo> SSNInfo { get; set; }

}