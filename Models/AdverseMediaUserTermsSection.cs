using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaUserTermsSection")]
public class AdverseMediaUserTermsSection
{
    [XmlElement("UserTermRecord")]
    public AdverseMediaUserTermRecord UserTermRecord { get; set; }
}
