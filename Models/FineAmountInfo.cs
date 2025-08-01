using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FineAmountInfo")]
public class FineAmountInfo
{
    [XmlElement("AssessmentAmount")]
    public string AssessmentAmount { get; set; }

    [XmlElement("CourtCostAmount")]
    public string CourtCostAmount { get; set; }

    [XmlElement("CourtOrderedPayment")]
    public string CourtOrderedPayment { get; set; }

    [XmlElement("FeeAmount")]
    public string FeeAmount { get; set; }

    [XmlElement("FinedAmount")]
    public string FinedAmount { get; set; }

    [XmlElement("RestitutionAmount")]
    public string RestitutionAmount { get; set; }

    [XmlElement("StayedFine")]
    public string StayedFine { get; set; }

}
}