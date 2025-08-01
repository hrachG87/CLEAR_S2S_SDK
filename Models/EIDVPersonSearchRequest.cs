using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EIDVPersonSearchRequest")]
public class EIDVPersonSearchRequest
{
    [XmlElement("InternalID")]
    public string InternalID { get; set; }

    [XmlElement("UserReference")]
    public List<string> UserReference { get; set; }

    [XmlElement("Criteria")]
    public EIDVPersonSearchCriteria Criteria { get; set; }

    [XmlElement("Datasources")]
    public IDConfirmPersonDatasources Datasources { get; set; }

    [XmlElement("EIDVVersion")]
    public string EIDVVersion { get; set; }

    [XmlElement("EIDVName")]
    public string EIDVName { get; set; }

}
}