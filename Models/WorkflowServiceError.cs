using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WorkflowServiceError")]
public class WorkflowServiceError
{
    [XmlElement("ErrorType")]
    public string ErrorType { get; set; }

    [XmlElement("ErrorMsg")]
    public string ErrorMsg { get; set; }

}