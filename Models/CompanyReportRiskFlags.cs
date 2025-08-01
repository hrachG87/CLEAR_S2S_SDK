using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyReportRiskFlags")]
public class CompanyReportRiskFlags
{
    [XmlElement("AssocWithOFACGlobalPEP")]
    public string AssocWithOFACGlobalPEP { get; set; }

    [XmlElement("OFAC")]
    public string OFAC { get; set; }

    [XmlElement("WorldCheck")]
    public string WorldCheck { get; set; }

    [XmlElement("GlobalSanctions")]
    public string GlobalSanctions { get; set; }

    [XmlElement("ResidentialUsedAsBusiness")]
    public string ResidentialUsedAsBusiness { get; set; }

    [XmlElement("PrisonAddress")]
    public string PrisonAddress { get; set; }

    [XmlElement("Bankruptcy")]
    public string Bankruptcy { get; set; }

    [XmlElement("AssocRelativeWithResidentialUsedAsBusiness")]
    public string AssocRelativeWithResidentialUsedAsBusiness { get; set; }

    [XmlElement("AssocRelativeWithPrisonAddress")]
    public string AssocRelativeWithPrisonAddress { get; set; }

    [XmlElement("AssocRelativeWithPOBoxAddress")]
    public string AssocRelativeWithPOBoxAddress { get; set; }

    [XmlElement("Criminal")]
    public string Criminal { get; set; }

    [XmlElement("MultipleSSN")]
    public string MultipleSSN { get; set; }

    [XmlElement("RecordedAsDeceased")]
    public string RecordedAsDeceased { get; set; }

    [XmlElement("AgeYoungerThanSSN")]
    public string AgeYoungerThanSSN { get; set; }

    [XmlElement("AddressReportedLessNinetyDays")]
    public string AddressReportedLessNinetyDays { get; set; }

    [XmlElement("HealthcareSanction")]
    public string HealthcareSanction { get; set; }

    [XmlElement("PhoneNumberInconsistentAddress")]
    public string PhoneNumberInconsistentAddress { get; set; }

    [XmlElement("Arrest")]
    public string Arrest { get; set; }

    [XmlElement("POBoxAddress")]
    public string POBoxAddress { get; set; }

    [XmlElement("SSNMultipleIndividuals")]
    public string SSNMultipleIndividuals { get; set; }

    [XmlElement("SSNFormatInvalid")]
    public string SSNFormatInvalid { get; set; }
}
