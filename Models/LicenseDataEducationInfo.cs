using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LicenseDataEducationInfo")]
public class LicenseDataEducationInfo
{
    [XmlElement("CollegeDegree")]
    public CollegeDegree CollegeDegree { get; set; }

    [XmlElement("ContEdHrsCompleted")]
    public string ContEdHrsCompleted { get; set; }

    [XmlElement("ContEdHrsRequired")]
    public string ContEdHrsRequired { get; set; }

    [XmlElement("ContEducation")]
    public List<string> ContEducation { get; set; }

    [XmlElement("ContEducationStatus")]
    public List<string> ContEducationStatus { get; set; }

    [XmlElement("ContinuingEducationDate")]
    public List<string> ContinuingEducationDate { get; set; }

    [XmlElement("ContinuingMedEd")]
    public string ContinuingMedEd { get; set; }

    [XmlElement("MedSchoolDomain")]
    public string MedSchoolDomain { get; set; }

    [XmlElement("PreLicenseEdPrep")]
    public string PreLicenseEdPrep { get; set; }

    [XmlElement("SchoolEntryDate")]
    public string SchoolEntryDate { get; set; }

    [XmlElement("SchoolInfo")]
    public List<SchoolInfo> SchoolInfo { get; set; }

}
}