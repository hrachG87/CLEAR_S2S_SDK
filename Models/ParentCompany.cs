using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ParentCompany")]
public class ParentCompany
{
    [XmlElement("ParentDUNSNumber")]
    public string ParentDUNSNumber { get; set; }

    [XmlElement("ParentCompanyName")]
    public string ParentCompanyName { get; set; }

    [XmlElement("ParentCompanyAddress")]
    public CommonDataAddress ParentCompanyAddress { get; set; }
}
