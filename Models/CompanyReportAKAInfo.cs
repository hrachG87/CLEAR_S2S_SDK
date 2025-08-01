using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyReportAKAInfo")]
public class CompanyReportAKAInfo
{
    [XmlElement("NameFirstReported")]
    public string NameFirstReported { get; set; }

    [XmlElement("Also Known As (AKA) Name")]
    public PersonName AlsoKnownAsAKAName { get; set; }

}