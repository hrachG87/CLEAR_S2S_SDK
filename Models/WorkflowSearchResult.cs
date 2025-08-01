using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WorkflowSearchResult")]
public class WorkflowSearchResult
{
    [XmlElement("Result")]
    public List<ResultType> Result { get; set; }
}
