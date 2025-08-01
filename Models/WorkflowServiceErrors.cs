using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WorkflowServiceErrors")]
public class WorkflowServiceErrors
{
    [XmlElement("ServiceError")]
    public List<WorkflowServiceError> ServiceError { get; set; }

}
}