using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonReportRiskFlagsWithDocguids")]
public class PersonReportRiskFlagsWithDocguids
{
    [XmlElement("AssocWithOFACGlobalPEP")]
    public PersonReportRiskFlagInfo AssocWithOFACGlobalPEP { get; set; }

    [XmlElement("OFAC")]
    public PersonReportRiskFlagInfo OFAC { get; set; }

    [XmlElement("WorldCheck")]
    public PersonReportRiskFlagInfo WorldCheck { get; set; }

    [XmlElement("GlobalSanctions")]
    public PersonReportRiskFlagInfo GlobalSanctions { get; set; }

    [XmlElement("ResidentialUsedAsBusiness")]
    public PersonReportRiskFlagInfo ResidentialUsedAsBusiness { get; set; }

    [XmlElement("Prison Address")]
    public PersonReportRiskFlagInfo Prison Address { get; set; }

    [XmlElement("Bankruptcy")]
    public PersonReportRiskFlagInfo Bankruptcy { get; set; }

    [XmlElement("AssocRelativeWithResidentialUsedAsBusiness")]
    public PersonReportRiskFlagInfo AssocRelativeWithResidentialUsedAsBusiness { get; set; }

    [XmlElement("AssocRelativeWithPrisonAddress")]
    public PersonReportRiskFlagInfo AssocRelativeWithPrisonAddress { get; set; }

    [XmlElement("AssocRelativeWithPOBoxAddress")]
    public PersonReportRiskFlagInfo AssocRelativeWithPOBoxAddress { get; set; }

    [XmlElement("Criminal")]
    public PersonReportRiskFlagInfo Criminal { get; set; }

    [XmlElement("CriminalLowLevelTrafficOffense")]
    public PersonReportRiskFlagInfo CriminalLowLevelTrafficOffense { get; set; }

    [XmlElement("CriminalUncategorized")]
    public PersonReportRiskFlagInfo CriminalUncategorized { get; set; }

    [XmlElement("MultipleSSN")]
    public PersonReportRiskFlagInfo MultipleSSN { get; set; }

    [XmlElement("RecordedAsDeceased")]
    public PersonReportRiskFlagInfo RecordedAsDeceased { get; set; }

    [XmlElement("AgeYoungerThanSSN")]
    public PersonReportRiskFlagInfo AgeYoungerThanSSN { get; set; }

    [XmlElement("AddressReportedLessThanNinetyDays")]
    public PersonReportRiskFlagInfo AddressReportedLessThanNinetyDays { get; set; }

    [XmlElement("HealthcareSanction")]
    public PersonReportRiskFlagInfo HealthcareSanction { get; set; }

    [XmlElement("PhoneNumberInconsistentAddress")]
    public PersonReportRiskFlagInfo PhoneNumberInconsistentAddress { get; set; }

    [XmlElement("Arrest")]
    public PersonReportRiskFlagInfo Arrest { get; set; }

    [XmlElement("AssociatedWithMarijuanaBusiness")]
    public PersonReportRiskFlagInfo AssociatedWithMarijuanaBusiness { get; set; }

    [XmlElement("POBoxAddress")]
    public PersonReportRiskFlagInfo POBoxAddress { get; set; }

    [XmlElement("SSNMultipleIndividuals")]
    public PersonReportRiskFlagInfo SSNMultipleIndividuals { get; set; }

    [XmlElement("SSNFormatInvalid")]
    public PersonReportRiskFlagInfo SSNFormatInvalid { get; set; }
}
