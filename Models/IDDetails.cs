using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("IDDetails")]
public class IDDetails
{
    [XmlElement("StateID")]
    public string StateID { get; set; }

    [XmlElement("FullStateID")]
    public string FullStateID { get; set; }

    [XmlElement("IDIssuer")]
    public string IDIssuer { get; set; }

    [XmlElement("IDType")]
    public string IDType { get; set; }

    [XmlElement("IDNumber")]
    public string IDNumber { get; set; }

}
}