using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ClearReportApiStatus")]
public class ClearReportApiStatus
{
    [XmlElement("StatusCode")]
    public int StatusCode { get; set; }

    [XmlElement("SubStatusCode")]
    public int SubStatusCode { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Message")]
    public string Message { get; set; }

    [XmlElement("ReportType")]
    public string ReportType { get; set; }

    [XmlElement("ReportSubject")]
    public string ReportSubject { get; set; }

    [XmlElement("EntityId")]
    public string EntityId { get; set; }

    [XmlElement("TimeStamp")]
    public string TimeStamp { get; set; }

}