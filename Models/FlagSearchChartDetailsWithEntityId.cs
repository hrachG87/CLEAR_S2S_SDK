using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("FlagSearchChartDetailsWithEntityId")]
public class FlagSearchChartDetailsWithEntityId
{
    [XmlElement("EntityID")]
    public string EntityID { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("AssociationAddress")]
    public List<CommonDataAddress> AssociationAddress { get; set; }

    [XmlElement("AssociationPhoneNumber")]
    public List<PhoneInfo> AssociationPhoneNumber { get; set; }

    [XmlElement("AssociationType")]
    public FlagsSearchAssociationType AssociationType { get; set; }

    [XmlElement("PersonRiskFlagsWithDocguids")]
    public PersonRiskFlagsWithDocguids PersonRiskFlagsWithDocguids { get; set; }

    [XmlElement("CompanyRiskFlagsWithDocguids")]
    public CompanyRiskFlagsWithDocguids CompanyRiskFlagsWithDocguids { get; set; }

    [XmlElement("StrengthOfAssociation")]
    public int StrengthOfAssociation { get; set; }

    [XmlElement("DateOfBirth")]
    public string DateOfBirth { get; set; }

    [XmlElement("Associations")]
    public List<AnalyticalAssociation> Associations { get; set; }
}
