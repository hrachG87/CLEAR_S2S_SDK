using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PrescriptionFraud")]
public class PrescriptionFraud
{
    [XmlElement("PrescriptionFraudFlag")]
    public RiskFlagInfo PrescriptionFraudFlag { get; set; }

}