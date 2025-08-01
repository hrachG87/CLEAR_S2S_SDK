using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyUserTermsSection")]
public class CompanyUserTermsSection
{
    [XmlElement("UserTermRecord")]
    public CompanyUserTermRecord UserTermRecord { get; set; }
}
