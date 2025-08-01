using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ArrestRecord")]
public class ArrestRecord
{
    [XmlElement("Address")]
    public List<CommonDataAddress> Address { get; set; }

    [XmlElement("ArrestInfo")]
    public List<CriminalDataArrestInfo> ArrestInfo { get; set; }

    [XmlElement("CourtInfo")]
    public List<CriminalDataCourtInfo> CourtInfo { get; set; }

    [XmlElement("CriminalCharges")]
    public List<CriminalCharges> CriminalCharges { get; set; }

    [XmlElement("InstitutionInfo")]
    public List<InstitutionInfo> InstitutionInfo { get; set; }

    [XmlElement("PersonInfo")]
    public CriminalPersonInfo PersonInfo { get; set; }

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