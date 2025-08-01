using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonRiskFlagsWithDocguids")]
public class PersonRiskFlagsWithDocguids
{
    [XmlElement("AssocWithOFACGlobalPEP")]
    public PersonRiskFlagInfo AssocWithOFACGlobalPEP { get; set; }

    [XmlElement("Ofac")]
    public PersonRiskFlagInfo Ofac { get; set; }

    [XmlElement("WorldCheck")]
    public PersonRiskFlagInfo WorldCheck { get; set; }

    [XmlElement("GlobalSanctions")]
    public PersonRiskFlagInfo GlobalSanctions { get; set; }

    [XmlElement("ResidentialUsedAsBusiness")]
    public PersonRiskFlagInfo ResidentialUsedAsBusiness { get; set; }

    [XmlElement("PrisonAddress")]
    public PersonRiskFlagInfo PrisonAddress { get; set; }

    [XmlElement("Bankruptcy")]
    public PersonRiskFlagInfo Bankruptcy { get; set; }

    [XmlElement("AssocRelativeWithResidentialUsedAsBusiness")]
    public PersonRiskFlagInfo AssocRelativeWithResidentialUsedAsBusiness { get; set; }

    [XmlElement("AssocRelativeWithPrisonAddress")]
    public PersonRiskFlagInfo AssocRelativeWithPrisonAddress { get; set; }

    [XmlElement("AssocRelativeWithPOBoxAddress")]
    public PersonRiskFlagInfo AssocRelativeWithPOBoxAddress { get; set; }

    [XmlElement("Criminal")]
    public PersonRiskFlagInfo Criminal { get; set; }

    [XmlElement("CriminalLowLevelTrafficOffense")]
    public PersonRiskFlagInfo CriminalLowLevelTrafficOffense { get; set; }

    [XmlElement("SexOffender")]
    public PersonRiskFlagInfo SexOffender { get; set; }

    [XmlElement("CriminalUncategorized")]
    public PersonRiskFlagInfo CriminalUncategorized { get; set; }

    [XmlElement("MultipleSSN")]
    public PersonRiskFlagInfo MultipleSSN { get; set; }

    [XmlElement("RecordedAsDeceased")]
    public PersonRiskFlagInfo RecordedAsDeceased { get; set; }

    [XmlElement("AgeYoungerThanSSN")]
    public PersonRiskFlagInfo AgeYoungerThanSSN { get; set; }

    [XmlElement("AddressReportedLessNinetyDays")]
    public PersonRiskFlagInfo AddressReportedLessNinetyDays { get; set; }

    [XmlElement("HealthcareSanction")]
    public PersonRiskFlagInfo HealthcareSanction { get; set; }

    [XmlElement("PhoneNumberInconsistentAddress")]
    public PersonRiskFlagInfo PhoneNumberInconsistentAddress { get; set; }

    [XmlElement("Arrest")]
    public PersonRiskFlagInfo Arrest { get; set; }

    [XmlElement("RealTimeIncarcerationAndArrest")]
    public PersonRiskFlagInfo RealTimeIncarcerationAndArrest { get; set; }

    [XmlElement("AssociatedWithMarijuanaBusiness")]
    public PersonRiskFlagInfo AssociatedWithMarijuanaBusiness { get; set; }

    [XmlElement("POBoxAddress")]
    public PersonRiskFlagInfo POBoxAddress { get; set; }

    [XmlElement("SSNMultipleIndividuals")]
    public PersonRiskFlagInfo SSNMultipleIndividuals { get; set; }

    [XmlElement("SSNIsITIN")]
    public PersonRiskFlagInfo SSNIsITIN { get; set; }

    [XmlElement("SSNFormatInvalid")]
    public PersonRiskFlagInfo SSNFormatInvalid { get; set; }

}
}