using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AssociateSection")]
public class AssociateSection
{
    [XmlElement("AssociateRecord")]
    public List<AssociateRecord> AssociateRecord { get; set; }

}