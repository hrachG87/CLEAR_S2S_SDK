using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ExecutiveAffiliationRecord")]
public class ExecutiveAffiliationRecord
{
    [XmlElement("BusinessInfo")]
    public BusinessDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("PersonInfo")]
    public BusinessPersonInfo PersonInfo { get; set; }

    [XmlElement("TradeStyle")]
    public string TradeStyle { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}