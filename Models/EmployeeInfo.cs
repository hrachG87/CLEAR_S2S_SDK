using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EmployeeInfo")]
public class EmployeeInfo
{
    [XmlElement("Employer")]
    public Employer Employer { get; set; }

    [XmlElement("EmployerAddress")]
    public CommonDataAddress EmployerAddress { get; set; }

    [XmlElement("EmployerPhoneInfo")]
    public PhoneInfo EmployerPhoneInfo { get; set; }

    [XmlElement("HireDate")]
    public string HireDate { get; set; }

    [XmlElement("ReleaseDate")]
    public string ReleaseDate { get; set; }

    [XmlElement("SupervisorInfo")]
    public SupervisorInfo SupervisorInfo { get; set; }

    [XmlElement("EmployeeOccupationCategory")]
    public string EmployeeOccupationCategory { get; set; }

    [XmlElement("EmployeePositionName")]
    public string EmployeePositionName { get; set; }

    [XmlElement("EmploymentStatus")]
    public EmploymentStatus EmploymentStatus { get; set; }

}
}