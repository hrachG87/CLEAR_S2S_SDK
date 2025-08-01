using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RelativeSection")]
public class RelativeSection
{
    [XmlElement("RelativeRecord")]
    public List<RelativeRecord> RelativeRecord { get; set; }

}
}