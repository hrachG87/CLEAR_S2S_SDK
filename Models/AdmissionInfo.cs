using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdmissionInfo")]
public class AdmissionInfo
{
    [XmlElement("AdmissionDate")]
    public string AdmissionDate { get; set; }

    [XmlElement("InstitutionLocation")]
    public string InstitutionLocation { get; set; }

    [XmlElement("TypeOfAdmission")]
    public string TypeOfAdmission { get; set; }

}
}