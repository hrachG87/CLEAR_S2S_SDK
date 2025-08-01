using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Insurance")]
public class Insurance
{
    [XmlElement("InsurancePolicyID")]
    public string InsurancePolicyID { get; set; }

    [XmlElement("InsuranceCarrierName")]
    public string InsuranceCarrierName { get; set; }

    [XmlElement("InsuranceCancellationDate")]
    public string InsuranceCancellationDate { get; set; }

    [XmlElement("InsuranceEffectiveDate")]
    public string InsuranceEffectiveDate { get; set; }

}