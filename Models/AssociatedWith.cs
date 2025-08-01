using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AssociatedWith")]
public class AssociatedWith
{
    [XmlElement("FullName")]
    public List<string> FullName { get; set; }
}
