using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessContactRecordBusinessInfo")]
public class BusinessContactRecordBusinessInfo
{
    [XmlElement("JobDepartment")]
    public string JobDepartment { get; set; }

    [XmlElement("JobLevel")]
    public string JobLevel { get; set; }

    [XmlElement("Organization")]
    public string Organization { get; set; }

    [XmlElement("OrganizationAddress")]
    public List<OrganizationAddress> OrganizationAddress { get; set; }

    [XmlElement("BusinessEmail")]
    public List<BusinessEmail> BusinessEmail { get; set; }

    [XmlElement("PhoneNumbers")]
    public List<PhoneNumbers> PhoneNumbers { get; set; }

    [XmlElement("LinkedInurl")]
    public string LinkedInurl { get; set; }

}