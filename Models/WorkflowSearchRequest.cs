using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WorkflowSearchRequest")]
public class WorkflowSearchRequest
{
    [XmlElement("PermissiblePurpose")]
    public PermissiblePurpose PermissiblePurpose { get; set; }

    [XmlElement("ClientID")]
    public string ClientID { get; set; }

    [XmlElement("ContentType")]
    public string ContentType { get; set; }

    [XmlElement("Workflow")]
    public WorkflowType Workflow { get; set; }

    [XmlElement("CriteriaList")]
    public CriteriaList CriteriaList { get; set; }

}