using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonAssociateRiskFlags")]
public class PersonAssociateRiskFlags
{
    [XmlElement("AssocWithOFACGlobalPEP")]
    public bool AssocWithOFACGlobalPEP { get; set; }

    [XmlElement("OFAC")]
    public bool OFAC { get; set; }

    [XmlElement("WorldCheck")]
    public bool WorldCheck { get; set; }

    [XmlElement("GlobalSanctions")]
    public bool GlobalSanctions { get; set; }

    [XmlElement("ResidentialUsedAsBusiness")]
    public bool ResidentialUsedAsBusiness { get; set; }

    [XmlElement("PrisonAddress")]
    public bool PrisonAddress { get; set; }

    [XmlElement("Bankruptcy")]
    public bool Bankruptcy { get; set; }

    [XmlElement("AssocRelativeWithResidentialUsedAsBusiness")]
    public bool AssocRelativeWithResidentialUsedAsBusiness { get; set; }

    [XmlElement("AssocRelativeWithPrisonAddress")]
    public bool AssocRelativeWithPrisonAddress { get; set; }

    [XmlElement("AssocRelativeWithPOBoxAddress")]
    public bool AssocRelativeWithPOBoxAddress { get; set; }

    [XmlElement("Criminal")]
    public bool Criminal { get; set; }

    [XmlElement("MultipleSSN")]
    public bool MultipleSSN { get; set; }

    [XmlElement("RecordedAsDeceased")]
    public bool RecordedAsDeceased { get; set; }

    [XmlElement("AgeYoungerThanSSN")]
    public bool AgeYoungerThanSSN { get; set; }

    [XmlElement("AddressReportedLessNinetyDays")]
    public bool AddressReportedLessNinetyDays { get; set; }

    [XmlElement("HealthcareSanction")]
    public bool HealthcareSanction { get; set; }

    [XmlElement("PhoneNumberInconsistentAddress")]
    public bool PhoneNumberInconsistentAddress { get; set; }

    [XmlElement("Arrest")]
    public bool Arrest { get; set; }

    [XmlElement("RealTimeIncarcerationAndArrest")]
    public bool RealTimeIncarcerationAndArrest { get; set; }

    [XmlElement("AssociatedWithMarijuanaBusiness")]
    public bool AssociatedWithMarijuanaBusiness { get; set; }

    [XmlElement("SSNMultipleIndividuals")]
    public bool SSNMultipleIndividuals { get; set; }

    [XmlElement("SSNFormatInvalid")]
    public bool SSNFormatInvalid { get; set; }

    [XmlElement("POBoxAddress")]
    public bool POBoxAddress { get; set; }
}
