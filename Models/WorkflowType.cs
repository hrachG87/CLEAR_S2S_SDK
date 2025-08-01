using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WorkflowType")]
public class WorkflowType
{
    [XmlElement("value")]
    public string value { get; set; }

    [XmlElement("version")]
    public string version { get; set; }

}
}