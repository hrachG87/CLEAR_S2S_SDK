using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SubjectSection")]
public class SubjectSection
{
    [XmlElement("SubjectRecord")]
    public List<SubjectRecord> SubjectRecord { get; set; }
}
