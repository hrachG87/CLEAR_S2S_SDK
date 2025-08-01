using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ExecutiveProfileSection")]
public class ExecutiveProfileSection
{
    [XmlElement("ExecutiveProfileRecord")]
    public List<ExecutiveProfileRecord> ExecutiveProfileRecord { get; set; }

}
}