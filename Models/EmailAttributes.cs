using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EmailAttributes")]
public class EmailAttributes
{
    [XmlElement("Message")]
    public string Message { get; set; }

    [XmlElement("Valid")]
    public bool Valid { get; set; }

    [XmlElement("Disposable")]
    public bool Disposable { get; set; }

    [XmlElement("OverallScore")]
    public string OverallScore { get; set; }

    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("Generic")]
    public string Generic { get; set; }

    [XmlElement("Common")]
    public bool Common { get; set; }

    [XmlElement("Honeypot")]
    public bool Honeypot { get; set; }

    [XmlElement("Deliverability")]
    public string Deliverability { get; set; }

    [XmlElement("FrequentComplainer")]
    public bool FrequentComplainer { get; set; }

    [XmlElement("SpamTrapScore")]
    public string SpamTrapScore { get; set; }

    [XmlElement("CatchAll")]
    public bool CatchAll { get; set; }

    [XmlElement("Suspect")]
    public bool Suspect { get; set; }

    [XmlElement("RecentAbuse")]
    public bool RecentAbuse { get; set; }

    [XmlElement("FraudScore")]
    public string FraudScore { get; set; }

    [XmlElement("SuggestedDomain")]
    public string SuggestedDomain { get; set; }

    [XmlElement("Leaked")]
    public bool Leaked { get; set; }

    [XmlElement("DomainTrust")]
    public string DomainTrust { get; set; }

    [XmlElement("DomainVelocity")]
    public string DomainVelocity { get; set; }

    [XmlElement("UserActivity")]
    public string UserActivity { get; set; }

    [XmlElement("DomainAge")]
    public DomainAge DomainAge { get; set; }

    [XmlElement("FirstSeen")]
    public FirstSeen FirstSeen { get; set; }

    [XmlElement("AssociatedNames")]
    public AssociatedNames AssociatedNames { get; set; }

    [XmlElement("AssociatedPhoneNumbers")]
    public AssociatedPhoneNumbers AssociatedPhoneNumbers { get; set; }

    [XmlElement("RiskyTld")]
    public string RiskyTld { get; set; }

    [XmlElement("DmarcRecord")]
    public string DmarcRecord { get; set; }

    [XmlElement("SMTPScore")]
    public string SMTPScore { get; set; }

    [XmlElement("DNSValid")]
    public bool DNSValid { get; set; }

    [XmlElement("MXRecords")]
    public List<string> MXRecords { get; set; }

    [XmlElement("SPFRecord")]
    public string SPFRecord { get; set; }
}
