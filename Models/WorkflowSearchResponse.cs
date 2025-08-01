using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WorkflowSearchResponse")]
public class WorkflowSearchResponse
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("WorkflowSearchResult")]
    public WorkflowSearchResult WorkflowSearchResult { get; set; }

    [XmlElement("ServiceErrors")]
    public WorkflowServiceErrors ServiceErrors { get; set; }

}