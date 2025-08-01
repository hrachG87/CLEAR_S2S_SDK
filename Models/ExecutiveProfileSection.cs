using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ExecutiveProfileSection")]
public class ExecutiveProfileSection
{
    [XmlElement("ExecutiveProfileRecord")]
    public List<ExecutiveProfileRecord> ExecutiveProfileRecord { get; set; }

}