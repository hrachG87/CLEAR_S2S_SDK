using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CommercialFraudShieldSection")]
public class CommercialFraudShieldSection
{
    [XmlElement("CommercialFraudShieldRecord")]
    public List<CommercialFraudShieldRecord> CommercialFraudShieldRecord { get; set; }

}