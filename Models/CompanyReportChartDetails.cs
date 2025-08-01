using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyReportChartDetails")]
public class CompanyReportChartDetails
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("AssociationAddress")]
    public List<CommonDataAddress> AssociationAddress { get; set; }

    [XmlElement("AssociationPhoneNumber")]
    public List<PhoneInfo> AssociationPhoneNumber { get; set; }

    [XmlElement("RiskFlags")]
    public CompanyReportRiskFlags RiskFlags { get; set; }

    [XmlElement("StrengthOfAssociation")]
    public int StrengthOfAssociation { get; set; }

    [XmlElement("Associations")]
    public List<AnalyticalAssociation> Associations { get; set; }
}
