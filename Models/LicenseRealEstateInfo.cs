using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LicenseRealEstateInfo")]
public class LicenseRealEstateInfo
{
    [XmlElement("BranchNumber")]
    public string BranchNumber { get; set; }

    [XmlElement("BrokerExamDate")]
    public string BrokerExamDate { get; set; }

    [XmlElement("BrokerName")]
    public string BrokerName { get; set; }

    [XmlElement("BrokerNumber")]
    public string BrokerNumber { get; set; }

    [XmlElement("Department")]
    public string Department { get; set; }

    [XmlElement("DualBroker")]
    public string DualBroker { get; set; }

    [XmlElement("EthicsAgency")]
    public string EthicsAgency { get; set; }

    [XmlElement("EthicsAgencyInd")]
    public string EthicsAgencyInd { get; set; }

    [XmlElement("InactiveDate")]
    public string InactiveDate { get; set; }

    [XmlElement("LimitedBroker")]
    public string LimitedBroker { get; set; }

    [XmlElement("MiscIndicatorResult")]
    public string MiscIndicatorResult { get; set; }

    [XmlElement("MultiLicense")]
    public string MultiLicense { get; set; }

    [XmlElement("NextRenewalDate")]
    public string NextRenewalDate { get; set; }

    [XmlElement("PrincipalBroker")]
    public string PrincipalBroker { get; set; }

    [XmlElement("SalesEducationStatus")]
    public string SalesEducationStatus { get; set; }

    [XmlElement("SubdividedLand")]
    public string SubdividedLand { get; set; }

    [XmlElement("TypeOfRecord")]
    public string TypeOfRecord { get; set; }

}