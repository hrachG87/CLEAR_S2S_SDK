using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CommercialFraudShieldRecord")]
public class CommercialFraudShieldRecord
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("BusinessAddress")]
    public Address BusinessAddress { get; set; }

    [XmlElement("ActiveBusinessIndicator")]
    public bool ActiveBusinessIndicator { get; set; }

    [XmlElement("VerificationTriggerAssessment")]
    public string VerificationTriggerAssessment { get; set; }

    [XmlElement("BusinessVictimStatement")]
    public string BusinessVictimStatement { get; set; }

    [XmlElement("VictimStatementDetails")]
    public string VictimStatementDetails { get; set; }

    [XmlElement("PossibleOFACMatch")]
    public string PossibleOFACMatch { get; set; }

    [XmlElement("OFACDetails")]
    public string OFACDetails { get; set; }

    [XmlElement("OFACBusinessWithMatchingName")]
    public string OFACBusinessWithMatchingName { get; set; }

    [XmlElement("OFACBusinessWithMatchingCompanyAddress")]
    public Address OFACBusinessWithMatchingCompanyAddress { get; set; }

}