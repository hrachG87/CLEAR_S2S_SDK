using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AgencyInfo")]
public class AgencyInfo
{
    [XmlElement("AgencyName")]
    public string AgencyName { get; set; }

    [XmlElement("ArrestReason")]
    public string ArrestReason { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

}