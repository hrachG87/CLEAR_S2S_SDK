using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyUserTermRecord")]
public class CompanyUserTermRecord
{
    [XmlElement("PersonSearch")]
    public CompanyUserSearchInfo PersonSearch { get; set; }

    [XmlElement("BusinessSearch")]
    public CompanyUserSearchInfo BusinessSearch { get; set; }

    [XmlElement("PhoneSearch")]
    public CompanyUserSearchInfo PhoneSearch { get; set; }

    [XmlElement("LicenseSearch")]
    public CompanyUserSearchInfo LicenseSearch { get; set; }

    [XmlElement("VehicleSearch")]
    public CompanyUserSearchInfo VehicleSearch { get; set; }

    [XmlElement("RealPropertySearch")]
    public CompanyUserSearchInfo RealPropertySearch { get; set; }

    [XmlElement("CourtSearch")]
    public CompanyUserSearchInfo CourtSearch { get; set; }

    [XmlElement("WatercraftSearch")]
    public CompanyUserSearchInfo WatercraftSearch { get; set; }

    [XmlElement("ClearIDConfirmSearch")]
    public CompanyUserSearchInfo ClearIDConfirmSearch { get; set; }

    [XmlElement("RiskInformSearch")]
    public CompanyUserSearchInfo RiskInformSearch { get; set; }

}
}