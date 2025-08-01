using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OfficerAgentInfo")]
public class OfficerAgentInfo
{
    [XmlElement("OfficerAgentFullName")]
    public string OfficerAgentFullName { get; set; }

    [XmlElement("OfficerAgentFirstName")]
    public string OfficerAgentFirstName { get; set; }

    [XmlElement("OfficerAgentMiddleName")]
    public string OfficerAgentMiddleName { get; set; }

    [XmlElement("OfficerAgentLastName")]
    public string OfficerAgentLastName { get; set; }

    [XmlElement("OfficerAgentTitle")]
    public string OfficerAgentTitle { get; set; }

}
}