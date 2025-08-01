using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyReportChartDetailsWithEntityId")]
public class CompanyReportChartDetailsWithEntityId
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
    public CompanyReportAssociationType AssociationType { get; set; }

    [XmlElement("RiskFlagsWithDocguids")]
    public CompanyReportRiskFlagsWithDocguids RiskFlagsWithDocguids { get; set; }

    [XmlElement("StrengthOfAssociation")]
    public int StrengthOfAssociation { get; set; }

    [XmlElement("Association")]
    public List<AnalyticalAssociation> Association { get; set; }

}