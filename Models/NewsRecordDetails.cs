using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("NewsRecordDetails")]
public class NewsRecordDetails
{
    [XmlElement("RecordId")]
    public string RecordId { get; set; }

    [XmlElement("NewsResults")]
    public List<NewsResults> NewsResults { get; set; }

}