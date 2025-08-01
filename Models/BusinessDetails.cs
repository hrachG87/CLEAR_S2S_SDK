using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessDetails")]
public class BusinessDetails
{
    [XmlElement("LineOfBusiness")]
    public string LineOfBusiness { get; set; }

    [XmlElement("PrimarySIC")]
    public string PrimarySIC { get; set; }

    [XmlElement("PrimarySICDescription")]
    public string PrimarySICDescription { get; set; }

    [XmlElement("SecondarySICInfo")]
    public List<SecondarySICInfo> SecondarySICInfo { get; set; }

    [XmlElement("TotalEmployees")]
    public string TotalEmployees { get; set; }

    [XmlElement("EmployeesHere")]
    public string EmployeesHere { get; set; }
}
