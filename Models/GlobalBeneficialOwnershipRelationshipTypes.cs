using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GlobalBeneficialOwnershipRelationshipTypes")]
public class GlobalBeneficialOwnershipRelationshipTypes
{
    [XmlElement("Auditor")]
    public bool Auditor { get; set; }

    [XmlElement("Beneficial Owner")]
    public bool BeneficialOwner { get; set; }

    [XmlElement("Branch")]
    public bool Branch { get; set; }

    [XmlElement("Director")]
    public bool Director { get; set; }

    [XmlElement("Employee")]
    public bool Employee { get; set; }

    [XmlElement("Founder")]
    public bool Founder { get; set; }

    [XmlElement("Family")]
    public bool Family { get; set; }

    [XmlElement("Issuer")]
    public bool Issuer { get; set; }

    [XmlElement("Lawyer")]
    public bool Lawyer { get; set; }

    [XmlElement("Legal Representative")]
    public bool LegalRepresentative { get; set; }

    [XmlElement("Legal Predecessor")]
    public bool LegalPredecessor { get; set; }

    [XmlElement("Legal Successor")]
    public bool LegalSuccessor { get; set; }

    [XmlElement("Linked To")]
    public bool LinkedTo { get; set; }

    [XmlElement("Liquidator")]
    public bool Liquidator { get; set; }

    [XmlElement("Member of the Board")]
    public bool MemberoftheBoard { get; set; }

    [XmlElement("Manager")]
    public bool Manager { get; set; }

    [XmlElement("Officer")]
    public bool Officer { get; set; }

    [XmlElement("Partner")]
    public bool Partner { get; set; }

    [XmlElement("Registered Agent")]
    public bool RegisteredAgent { get; set; }

    [XmlElement("Shareholder")]
    public bool Shareholder { get; set; }

    [XmlElement("Subsidiary")]
    public bool Subsidiary { get; set; }

    [XmlElement("Supervisor")]
    public bool Supervisor { get; set; }

    [XmlElement("ShipperReceiver")]
    public bool ShipperReceiver { get; set; }

}