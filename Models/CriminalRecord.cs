using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalRecord")]
public class CriminalRecord
{
    [XmlElement("AdditionalNotes")]
    public List<AdditionalNotes> AdditionalNotes { get; set; }

    [XmlElement("Address")]
    public List<CommonDataAddress> Address { get; set; }

    [XmlElement("ArrestInfo")]
    public List<CriminalDataArrestInfo> ArrestInfo { get; set; }

    [XmlElement("BailInfo")]
    public List<CriminalDataBailInfo> BailInfo { get; set; }

    [XmlElement("CourtInfo")]
    public List<CriminalDataCourtInfo> CourtInfo { get; set; }

    [XmlElement("CriminalCharges")]
    public List<CriminalCharges> CriminalCharges { get; set; }

    [XmlElement("InmateDisciplineInfo")]
    public List<InmateDisciplineInfo> InmateDisciplineInfo { get; set; }

    [XmlElement("InmateReleaseInfo")]
    public List<InmateReleaseInfo> InmateReleaseInfo { get; set; }

    [XmlElement("InstitutionInfo")]
    public List<InstitutionInfo> InstitutionInfo { get; set; }

    [XmlElement("OfficeForeignAssetsControl")]
    public OfficeForeignAssetsControl OfficeForeignAssetsControl { get; set; }

    [XmlElement("ParoleInfo")]
    public List<ParoleInfo> ParoleInfo { get; set; }

    [XmlElement("PersonInfo")]
    public List<CriminalPersonInfo> PersonInfo { get; set; }

    [XmlElement("PleaInfo")]
    public List<CriminalPleaInfo> PleaInfo { get; set; }

    [XmlElement("PriorChargesInfo")]
    public List<PriorChargesInfo> PriorChargesInfo { get; set; }

    [XmlElement("ProbationInfo")]
    public List<ProbationInfo> ProbationInfo { get; set; }

    [XmlElement("SentencingInfo")]
    public List<CriminalSentencingInfo> SentencingInfo { get; set; }

    [XmlElement("SourceState")]
    public string SourceState { get; set; }

    [XmlElement("TypeOfCriminal")]
    public string TypeOfCriminal { get; set; }

    [XmlElement("TypeOfRecord")]
    public string TypeOfRecord { get; set; }

    [XmlElement("VehicleInfo")]
    public List<CriminalVehicleInfo> VehicleInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("PhotoImages")]
    public List<CriminalPhotoImages> PhotoImages { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("IDInfo")]
    public IDInfo IDInfo { get; set; }

}
}