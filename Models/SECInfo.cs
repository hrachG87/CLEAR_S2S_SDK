using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SECInfo")]
public class SECInfo
{
    [XmlElement("FormType")]
    public string FormType { get; set; }

    [XmlElement("FilingType")]
    public string FilingType { get; set; }

    [XmlElement("FileDate")]
    public string FileDate { get; set; }

    [XmlElement("PeriodDate")]
    public string PeriodDate { get; set; }

    [XmlElement("FileNumber")]
    public string FileNumber { get; set; }

    [XmlElement("TransactionEvent")]
    public string TransactionEvent { get; set; }

    [XmlElement("Description")]
    public string Description { get; set; }

}