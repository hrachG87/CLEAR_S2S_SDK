using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AttorneyProfInfo")]
public class AttorneyProfInfo
{
    [XmlElement("AdmittedLocation")]
    public string AdmittedLocation { get; set; }

    [XmlElement("AttorneyRegistrationId")]
    public string AttorneyRegistrationId { get; set; }

    [XmlElement("CompanionSwitch")]
    public string CompanionSwitch { get; set; }

    [XmlElement("JudicialDeptNum")]
    public string JudicialDeptNum { get; set; }

    [XmlElement("LastContactDate")]
    public string LastContactDate { get; set; }

    [XmlElement("LastRegStartYear")]
    public string LastRegStartYear { get; set; }

    [XmlElement("LocaleJudicialDistrictName")]
    public string LocaleJudicialDistrictName { get; set; }

    [XmlElement("ReasonNotRequired")]
    public string ReasonNotRequired { get; set; }

    [XmlElement("RegentsAction")]
    public string RegentsAction { get; set; }

    [XmlElement("Year")]
    public string Year { get; set; }

}
}