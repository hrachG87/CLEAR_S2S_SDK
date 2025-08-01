using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonJobs")]
public class PersonJobs
{
    [XmlElement("Job")]
    public string Job { get; set; }

    [XmlElement("TotalAdditionalJobs")]
    public string TotalAdditionalJobs { get; set; }

}