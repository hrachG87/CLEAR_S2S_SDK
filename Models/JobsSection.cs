using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("JobsSection")]
public class JobsSection
{
    [XmlElement("JobsRecord")]
    public List<JobInfo> JobsRecord { get; set; }
}
