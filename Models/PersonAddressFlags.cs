using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonAddressFlags")]
public class PersonAddressFlags
{
    [XmlElement("GovernmentalAddress")]
    public RiskFlagInfo GovernmentalAddress { get; set; }

    [XmlElement("CampSiteAddress")]
    public RiskFlagInfo CampSiteAddress { get; set; }

    [XmlElement("CheckCashingServiceAddress")]
    public RiskFlagInfo CheckCashingServiceAddress { get; set; }

    [XmlElement("CorrectionalInstitutionAddress")]
    public RiskFlagInfo CorrectionalInstitutionAddress { get; set; }

    [XmlElement("CreditCorrectionAddress")]
    public RiskFlagInfo CreditCorrectionAddress { get; set; }

    [XmlElement("HotelOrTemporaryAddress")]
    public RiskFlagInfo HotelOrTemporaryAddress { get; set; }

    [XmlElement("MailServiceAddress")]
    public RiskFlagInfo MailServiceAddress { get; set; }

    [XmlElement("NursingHomeAddress")]
    public RiskFlagInfo NursingHomeAddress { get; set; }

    [XmlElement("RestaurantBarNightClubAddress")]
    public RiskFlagInfo RestaurantBarNightClubAddress { get; set; }

    [XmlElement("SecretarialServiceAddress")]
    public RiskFlagInfo SecretarialServiceAddress { get; set; }

    [XmlElement("StorageFacilityAddress")]
    public RiskFlagInfo StorageFacilityAddress { get; set; }

    [XmlElement("TruckStopAddress")]
    public RiskFlagInfo TruckStopAddress { get; set; }

    [XmlElement("AirportAddress")]
    public RiskFlagInfo AirportAddress { get; set; }

    [XmlElement("CurrentAddrNotStateOfResidenceAddress")]
    public RiskFlagInfo CurrentAddrNotStateOfResidenceAddress { get; set; }

    [XmlElement("AddressNearNPLSite")]
    public RiskFlagInfo AddressNearNPLSite { get; set; }

    [XmlElement("AddressIsDEASite")]
    public RiskFlagInfo AddressIsDEASite { get; set; }

    [XmlElement("AddressInHIDTA")]
    public RiskFlagInfo AddressInHIDTA { get; set; }

    [XmlElement("AddressInHIFCA")]
    public RiskFlagInfo AddressInHIFCA { get; set; }

    [XmlElement("USAPostOfficeAddress")]
    public RiskFlagInfo USAPostOfficeAddress { get; set; }

}
}