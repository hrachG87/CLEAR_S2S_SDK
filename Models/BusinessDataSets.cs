using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessDataSets")]
public class BusinessDataSets
{
    [XmlElement("BusinessPhones")]
    public string BusinessPhones { get; set; }

    [XmlElement("CorporateFilings")]
    public string CorporateFilings { get; set; }

    [XmlElement("DunBradstreet")]
    public string DunBradstreet { get; set; }

    [XmlElement("FederalEmployerId")]
    public string FederalEmployerId { get; set; }

    [XmlElement("FicticiousBusinessName")]
    public string FicticiousBusinessName { get; set; }

    [XmlElement("PhoneRecords")]
    public string PhoneRecords { get; set; }

    [XmlElement("BusinessContactRecords")]
    public string BusinessContactRecords { get; set; }
}
