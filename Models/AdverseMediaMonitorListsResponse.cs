using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaMonitorListsResponse")]
public class AdverseMediaMonitorListsResponse
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("ListsResult")]
    public ListsResult ListsResult { get; set; }
}
