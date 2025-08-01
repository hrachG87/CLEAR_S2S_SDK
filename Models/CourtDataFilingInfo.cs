using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtDataFilingInfo")]
public class CourtDataFilingInfo
{
    [XmlElement("FilingNumberInfo")]
    public List<FilingNumberInfo> FilingNumberInfo { get; set; }

    [XmlElement("FilingOffice")]
    public List<FilingOffice> FilingOffice { get; set; }

    [XmlElement("TypeofFiling")]
    public List<string> TypeofFiling { get; set; }

    [XmlElement("UnlawfulDetainer")]
    public List<string> UnlawfulDetainer { get; set; }

    [XmlElement("FileDate")]
    public List<string> FileDate { get; set; }

    [XmlElement("FilingOfficeAddress")]
    public List<CommonDataAddress> FilingOfficeAddress { get; set; }

    [XmlElement("ReleaseDate")]
    public List<string> ReleaseDate { get; set; }

    [XmlElement("CertificateNumber")]
    public List<string> CertificateNumber { get; set; }

    [XmlElement("HiddenFilingNumber")]
    public List<string> HiddenFilingNumber { get; set; }

    [XmlElement("OrginalFilingNumber")]
    public List<string> OrginalFilingNumber { get; set; }

    [XmlElement("OriginalBook")]
    public List<string> OriginalBook { get; set; }

    [XmlElement("OriginalPage")]
    public List<string> OriginalPage { get; set; }

    [XmlElement("Court")]
    public string Court { get; set; }

    [XmlElement("ControlNumber")]
    public string ControlNumber { get; set; }

    [XmlElement("CourtCounty")]
    public string CourtCounty { get; set; }

    [XmlElement("CollectionDate")]
    public string CollectionDate { get; set; }

    [XmlElement("ComplaintDate")]
    public string ComplaintDate { get; set; }

    [XmlElement("FederalLienNumber")]
    public string FederalLienNumber { get; set; }

    [XmlElement("FilingOfficeDUNSNumber")]
    public string FilingOfficeDUNSNumber { get; set; }

    [XmlElement("MaturityDate")]
    public string MaturityDate { get; set; }

    [XmlElement("MultipleDebtors")]
    public string MultipleDebtors { get; set; }

    [XmlElement("OriginalFilingDate")]
    public string OriginalFilingDate { get; set; }

    [XmlElement("Paragraph")]
    public string Paragraph { get; set; }

    [XmlElement("PerfectedDate")]
    public string PerfectedDate { get; set; }

    [XmlElement("VendorNumber")]
    public string VendorNumber { get; set; }

    [XmlElement("DispositionInfo")]
    public CaseDisposition DispositionInfo { get; set; }

    [XmlElement("FilingTypeInfo")]
    public List<FilingTypeInfo> FilingTypeInfo { get; set; }

    [XmlElement("CaseDetails")]
    public string CaseDetails { get; set; }

    [XmlElement("ConvertDate")]
    public string ConvertDate { get; set; }

    [XmlElement("DemandAmount")]
    public string DemandAmount { get; set; }

    [XmlElement("DischargeDate")]
    public string DischargeDate { get; set; }

    [XmlElement("DismissalDate")]
    public string DismissalDate { get; set; }

    [XmlElement("FilingChapter")]
    public string FilingChapter { get; set; }

    [XmlElement("FilingDistrict")]
    public string FilingDistrict { get; set; }

    [XmlElement("FilingState")]
    public string FilingState { get; set; }

    [XmlElement("FilingStatusFlag")]
    public string FilingStatusFlag { get; set; }

    [XmlElement("FilingStatusTime")]
    public string FilingStatusTime { get; set; }

    [XmlElement("FinalDecreeDate")]
    public string FinalDecreeDate { get; set; }

    [XmlElement("KeyNatureOfSuit")]
    public string KeyNatureOfSuit { get; set; }

    [XmlElement("KeyNatureOfSuitCode")]
    public string KeyNatureOfSuitCode { get; set; }

    [XmlElement("OtherDockets")]
    public string OtherDockets { get; set; }

    [XmlElement("OtherDocketsTitle")]
    public string OtherDocketsTitle { get; set; }

    [XmlElement("ReopenedDate")]
    public string ReopenedDate { get; set; }

    [XmlElement("ReterminatedDate")]
    public string ReterminatedDate { get; set; }

    [XmlElement("StatusSetBy")]
    public string StatusSetBy { get; set; }

    [XmlElement("TerminatedDate")]
    public string TerminatedDate { get; set; }

    [XmlElement("CaseDispositionFinalDate")]
    public string CaseDispositionFinalDate { get; set; }

    [XmlElement("DocumentDescription")]
    public string DocumentDescription { get; set; }

    [XmlElement("DocumentFormat")]
    public string DocumentFormat { get; set; }

    [XmlElement("DocumentFiledDate")]
    public string DocumentFiledDate { get; set; }

    [XmlElement("DocumentID")]
    public string DocumentID { get; set; }

    [XmlElement("DocumentStatus")]
    public string DocumentStatus { get; set; }

    [XmlElement("StatusDate")]
    public string StatusDate { get; set; }

    [XmlElement("PreviousChapter")]
    public string PreviousChapter { get; set; }

    [XmlElement("NatureOfSuit")]
    public List<string> NatureOfSuit { get; set; }

    [XmlElement("IRSSerialNumber")]
    public List<string> IRSSerialNumber { get; set; }

}
}