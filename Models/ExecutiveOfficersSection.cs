using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ExecutiveOfficersSection")]
public class ExecutiveOfficersSection
{
    [XmlElement("ExecutiveOfficersRecord")]
    public List<ExecutiveOfficersRecord> ExecutiveOfficersRecord { get; set; }

}
}