using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WorkflowSearchResult")]
public class WorkflowSearchResult
{
    [XmlElement("Result")]
    public List<ResultType> Result { get; set; }

}
}