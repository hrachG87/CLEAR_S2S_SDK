using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonReportChartDetailsWithEntityId")]
public class PersonReportChartDetailsWithEntityId
{
    [XmlElement("EntityID")]
    public string EntityID { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("AssociationAddress")]
    public List<CommonDataAddress> AssociationAddress { get; set; }

    [XmlElement("AssociationPhoneNumber")]
    public List<PhoneInfo> AssociationPhoneNumber { get; set; }

    [XmlElement("RiskFlagsWithDocguids")]
    public PersonReportRiskFlagsWithDocguids RiskFlagsWithDocguids { get; set; }

    [XmlElement("StrengthOfAssociation")]
    public int StrengthOfAssociation { get; set; }

    [XmlElement("DateOfBirth")]
    public string DateOfBirth { get; set; }

    [XmlElement("Associations")]
    public List<AnalyticalAssociation> Associations { get; set; }
}
