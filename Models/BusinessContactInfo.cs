using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessContactInfo")]
public class BusinessContactInfo
{
    [XmlElement("ExecName")]
    public PersonName ExecName { get; set; }

    [XmlElement("Name")]
    public PersonName Name { get; set; }

    [XmlElement("Title")]
    public List<string> Title { get; set; }

    [XmlElement("AdditionalInfo")]
    public CompanyReportAdditionalInfo AdditionalInfo { get; set; }

}