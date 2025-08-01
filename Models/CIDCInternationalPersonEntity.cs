using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CIDCInternationalPersonEntity")]
public class CIDCInternationalPersonEntity
{
    [XmlElement("RecordNumber")]
    public string RecordNumber { get; set; }

    [XmlElement("TotalScore")]
    public string TotalScore { get; set; }

    [XmlElement("Message")]
    public string Message { get; set; }

    [XmlElement("Summary")]
    public CIDCInternationalSummary Summary { get; set; }

    [XmlElement("SearchRecords")]
    public CIDCInternationalSearchRecords SearchRecords { get; set; }

}