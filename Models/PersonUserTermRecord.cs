using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonUserTermRecord")]
public class PersonUserTermRecord
{
    [XmlElement("PersonSearch")]
    public PersonUserSearchInfo PersonSearch { get; set; }

    [XmlElement("BusinessSearch")]
    public PersonUserSearchInfo BusinessSearch { get; set; }

    [XmlElement("PhoneSearch")]
    public PersonUserSearchInfo PhoneSearch { get; set; }

    [XmlElement("LicenseSearch")]
    public PersonUserSearchInfo LicenseSearch { get; set; }

    [XmlElement("VehicelSearch")]
    public PersonUserSearchInfo VehicelSearch { get; set; }

    [XmlElement("RealPropertySearch")]
    public PersonUserSearchInfo RealPropertySearch { get; set; }

    [XmlElement("CourtSearch")]
    public PersonUserSearchInfo CourtSearch { get; set; }

    [XmlElement("WatercraftSearch")]
    public PersonUserSearchInfo WatercraftSearch { get; set; }

    [XmlElement("ClearIDConfirmSearch")]
    public PersonUserSearchInfo ClearIDConfirmSearch { get; set; }

    [XmlElement("RiskInformSearch")]
    public PersonUserSearchInfo RiskInformSearch { get; set; }

    [XmlElement("GlobalBeneficialOwnershipSearch")]
    public PersonUserSearchInfo GlobalBeneficialOwnershipSearch { get; set; }
}
