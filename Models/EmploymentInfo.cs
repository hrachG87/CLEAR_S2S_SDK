using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EmploymentInfo")]
public class EmploymentInfo
{
    [XmlElement("EmployerName")]
    public string EmployerName { get; set; }

    [XmlElement("EmployeeOccupation")]
    public string EmployeeOccupation { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }

}