using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaMonitorUserTermsSection")]
public class AdverseMediaMonitorUserTermsSection
{
    [XmlElement("UserTermRecord")]
    public AdverseMediaMonitorUserTermRecord UserTermRecord { get; set; }

}