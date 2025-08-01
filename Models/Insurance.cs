using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
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
}