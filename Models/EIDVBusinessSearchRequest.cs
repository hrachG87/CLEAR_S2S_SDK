using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EIDVBusinessSearchRequest")]
public class EIDVBusinessSearchRequest
{
    [XmlElement("InternalID")]
    public string InternalID { get; set; }

    [XmlElement("UserReference")]
    public List<string> UserReference { get; set; }

    [XmlElement("Criteria")]
    public EIDVBusinessSearchCriteria Criteria { get; set; }

    [XmlElement("Datasources")]
    public IDConfirmBusinessDatasources Datasources { get; set; }

    [XmlElement("EIDVVersion")]
    public string EIDVVersion { get; set; }

    [XmlElement("EIDVName")]
    public string EIDVName { get; set; }

}