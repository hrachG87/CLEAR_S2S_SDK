using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ExecutiveProfileRecord")]
public class ExecutiveProfileRecord
{
    [XmlElement("businessInfo")]
    public BusinessDataBusinessInfo businessInfo { get; set; }

    [XmlElement("personInfo")]
    public BusinessPersonInfo personInfo { get; set; }

    [XmlElement("EmployeeSizeDesc")]
    public string EmployeeSizeDesc { get; set; }

    [XmlElement("TotalSales")]
    public string TotalSales { get; set; }

    [XmlElement("CreditCardHolder")]
    public string CreditCardHolder { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
