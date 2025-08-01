using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AlertSubject")]
public class AlertSubject
{
    [XmlElement("UserReference")]
    public string UserReference { get; set; }

    [XmlElement("SubjectId")]
    public int SubjectId { get; set; }

    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("Keywords")]
    public string Keywords { get; set; }

    [XmlElement("DateOfBirth")]
    public string DateOfBirth { get; set; }

    [XmlElement("Location")]
    public string Location { get; set; }

}
}