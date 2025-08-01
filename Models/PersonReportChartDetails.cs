using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonReportChartDetails")]
public class PersonReportChartDetails
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("AssociationAddress")]
    public List<CommonDataAddress> AssociationAddress { get; set; }

    [XmlElement("AssociationPhoneNumber")]
    public List<PhoneInfo> AssociationPhoneNumber { get; set; }

    [XmlElement("RiskFlags")]
    public PersonReportRiskFlags RiskFlags { get; set; }

    [XmlElement("StrengthOfAssociation")]
    public int StrengthOfAssociation { get; set; }

    [XmlElement("DateOfBirth")]
    public string DateOfBirth { get; set; }

    [XmlElement("Associations")]
    public List<AnalyticalAssociation> Associations { get; set; }
}
