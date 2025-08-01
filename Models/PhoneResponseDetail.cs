using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PhoneResponseDetail")]
public class PhoneResponseDetail
{
    [XmlElement("ExperianRecord")]
    public List<ExperianRecord> ExperianRecord { get; set; }

    [XmlElement("HouseholdListingRecord")]
    public List<HouseholdListingRecord> HouseholdListingRecord { get; set; }

    [XmlElement("TransUnionRecord")]
    public List<TransUnionRecord> TransUnionRecord { get; set; }

    [XmlElement("PhoneRecord")]
    public List<PhoneRecord> PhoneRecord { get; set; }

    [XmlElement("WorldbaseRecord")]
    public List<WorldbaseRecord> WorldbaseRecord { get; set; }

    [XmlElement("UtilityRecord")]
    public List<UtilityRecord> UtilityRecord { get; set; }

    [XmlElement("BusinessPhoneRecord")]
    public List<BusinessPhoneRecord> BusinessPhoneRecord { get; set; }

    [XmlElement("CanadianPhoneRecord")]
    public List<CanadianPhoneRecord> CanadianPhoneRecord { get; set; }

    [XmlElement("CanadianBusinessPhoneRecord")]
    public List<BusinessPhoneRecord> CanadianBusinessPhoneRecord { get; set; }

    [XmlElement("DunBradstreetRecord")]
    public List<DunBradstreetRecord> DunBradstreetRecord { get; set; }

    [XmlElement("ReversePhoneRecord")]
    public List<ReversePhoneRecord> ReversePhoneRecord { get; set; }

    [XmlElement("DocumentGuids")]
    public List<Sources> DocumentGuids { get; set; }

    [XmlElement("MotorVehicleServiceAndWarrantyRecord")]
    public List<MotorVehicleServiceAndWarrantyRecord> MotorVehicleServiceAndWarrantyRecord { get; set; }

    [XmlElement("MarijuanaRelatedBusinessRecord")]
    public List<MarijuanaRelatedBusinessRecord> MarijuanaRelatedBusinessRecord { get; set; }

    [XmlElement("BankAccountHeaderRecord")]
    public List<BankAccountHeaderRecord> BankAccountHeaderRecord { get; set; }

    [XmlElement("BusinessContactRecord")]
    public List<BusinessContactRecord> BusinessContactRecord { get; set; }

    [XmlElement("PhoneAttributesRecord")]
    public List<PhoneAttributes> PhoneAttributesRecord { get; set; }

}
}