using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AssociateRecord")]
public class AssociateRecord
{
    [XmlElement("SubjectAddress")]
    public CommonDataAddress SubjectAddress { get; set; }

    [XmlElement("AssociateInfo")]
    public List<AssociateInfo> AssociateInfo { get; set; }
}
