using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AuditorInfo")]
public class AuditorInfo
{
    [XmlElement("ParentAuditor")]
    public string ParentAuditor { get; set; }
}
