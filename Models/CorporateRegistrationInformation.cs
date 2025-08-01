using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CorporateRegistrationInformation")]
public class CorporateRegistrationInformation
{
    [XmlElement("CorporateDetailHeading")]
    public string CorporateDetailHeading { get; set; }

    [XmlElement("RegisteredName")]
    public string RegisteredName { get; set; }

    [XmlElement("DateIncorporated")]
    public string DateIncorporated { get; set; }

    [XmlElement("StateOfIncorporation")]
    public string StateOfIncorporation { get; set; }

    [XmlElement("FilingDate")]
    public string FilingDate { get; set; }

    [XmlElement("RegistrationID")]
    public string RegistrationID { get; set; }

    [XmlElement("BusinessType")]
    public string BusinessType { get; set; }

    [XmlElement("CorporateType")]
    public string CorporateType { get; set; }

    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("WhereFiled")]
    public WhereFiled WhereFiled { get; set; }

    [XmlElement("RegisteredAgent")]
    public RegisteredAgent RegisteredAgent { get; set; }
}
