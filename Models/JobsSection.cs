using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("JobsSection")]
public class JobsSection
{
    [XmlElement("JobsRecord")]
    public List<JobInfo> JobsRecord { get; set; }

}
}