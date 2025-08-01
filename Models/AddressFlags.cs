using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AddressFlags")]
public class AddressFlags
{
    [XmlElement("CheckCahsingServiceAddress")]
    public BusinessRiskFlagInfo CheckCahsingServiceAddress { get; set; }

    [XmlElement("NursingHomeAddress")]
    public BusinessRiskFlagInfo NursingHomeAddress { get; set; }

    [XmlElement("MailServiceAddress")]
    public BusinessRiskFlagInfo MailServiceAddress { get; set; }

    [XmlElement("RestaurantBarNightclubAddress")]
    public BusinessRiskFlagInfo RestaurantBarNightclubAddress { get; set; }

    [XmlElement("HospitalAddress")]
    public BusinessRiskFlagInfo HospitalAddress { get; set; }

    [XmlElement("GovernmentalAddress")]
    public BusinessRiskFlagInfo GovernmentalAddress { get; set; }

    [XmlElement("CorrectionalInstitutionAddress")]
    public BusinessRiskFlagInfo CorrectionalInstitutionAddress { get; set; }

    [XmlElement("HotelOrTemporaryAddress")]
    public BusinessRiskFlagInfo HotelOrTemporaryAddress { get; set; }

    [XmlElement("SecretarialServiceAddress")]
    public BusinessRiskFlagInfo SecretarialServiceAddress { get; set; }

    [XmlElement("CreditCorrectionAddress")]
    public BusinessRiskFlagInfo CreditCorrectionAddress { get; set; }

    [XmlElement("StorageFacilityAddress")]
    public BusinessRiskFlagInfo StorageFacilityAddress { get; set; }

    [XmlElement("AirportAddress")]
    public BusinessRiskFlagInfo AirportAddress { get; set; }

    [XmlElement("CampSiteAddress")]
    public BusinessRiskFlagInfo CampSiteAddress { get; set; }

    [XmlElement("TruckStopAddress")]
    public BusinessRiskFlagInfo TruckStopAddress { get; set; }

    [XmlElement("BizUsedAsResidentialAddress")]
    public BusinessRiskFlagInfo BizUsedAsResidentialAddress { get; set; }

    [XmlElement("SexOffenderAddress")]
    public BusinessRiskFlagInfo SexOffenderAddress { get; set; }

    [XmlElement("AddressNearNPLSite")]
    public BusinessRiskFlagInfo AddressNearNPLSite { get; set; }

    [XmlElement("AddressIsDEASite")]
    public BusinessRiskFlagInfo AddressIsDEASite { get; set; }

    [XmlElement("AddressInHIDTA")]
    public BusinessRiskFlagInfo AddressInHIDTA { get; set; }

    [XmlElement("AddressInHIFCA")]
    public BusinessRiskFlagInfo AddressInHIFCA { get; set; }

    [XmlElement("POBoxAddress")]
    public BusinessRiskFlagInfo POBoxAddress { get; set; }

    [XmlElement("USAPostOfficeAddress")]
    public BusinessRiskFlagInfo USAPostOfficeAddress { get; set; }

}