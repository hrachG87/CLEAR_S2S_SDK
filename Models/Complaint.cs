using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Complaint")]
public class Complaint
{
    [XmlElement("ComplaintDate")]
    public string ComplaintDate { get; set; }

    [XmlElement("ComplaintNumber")]
    public string ComplaintNumber { get; set; }

    [XmlElement("TypeOfComplaint")]
    public string TypeOfComplaint { get; set; }

    [XmlElement("disposition")]
    public CaseDisposition disposition { get; set; }

}
}