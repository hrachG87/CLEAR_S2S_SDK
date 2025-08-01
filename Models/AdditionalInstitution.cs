using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdditionalInstitution")]
public class AdditionalInstitution
{
    [XmlElement("AssignmentTypeDesc")]
    public string AssignmentTypeDesc { get; set; }

    [XmlElement("CustodyReviewDate")]
    public string CustodyReviewDate { get; set; }

    [XmlElement("CustodyReviewDesc")]
    public string CustodyReviewDesc { get; set; }

    [XmlElement("AdmissionInfo")]
    public AdmissionInfo AdmissionInfo { get; set; }

}
}