using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("GeneralInformation")]
public class GeneralInformation
{
    [XmlElement("BusinessInfo")]
    public BusinessDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("FaxNumber")]
    public List<string> FaxNumber { get; set; }

    [XmlElement("URL")]
    public List<string> URL { get; set; }

    [XmlElement("ChiefExecutiveOfficer")]
    public string ChiefExecutiveOfficer { get; set; }

    [XmlElement("FinancialOperations")]
    public string FinancialOperations { get; set; }

    [XmlElement("ReportInformationDate")]
    public string ReportInformationDate { get; set; }

    [XmlElement("CreditScoreComments")]
    public List<string> CreditScoreComments { get; set; }

}
}