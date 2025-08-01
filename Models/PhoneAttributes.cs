using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PhoneAttributes")]
public class PhoneAttributes
{
    [XmlElement("Valid")]
    public bool Valid { get; set; }

    [XmlElement("RecentAbuse")]
    public bool RecentAbuse { get; set; }

    [XmlElement("VOIP")]
    public bool VOIP { get; set; }

    [XmlElement("Prepaid")]
    public string Prepaid { get; set; }

    [XmlElement("Risky")]
    public bool Risky { get; set; }

    [XmlElement("Active")]
    public bool Active { get; set; }

    [XmlElement("Leaked")]
    public bool Leaked { get; set; }

    [XmlElement("Spammer")]
    public bool Spammer { get; set; }

    [XmlElement("AccurateCountryCode")]
    public bool AccurateCountryCode { get; set; }

    [XmlElement("DoNotCall")]
    public bool DoNotCall { get; set; }

    [XmlElement("Message")]
    public string Message { get; set; }

    [XmlElement("Formatted")]
    public string Formatted { get; set; }

    [XmlElement("LocalFormat")]
    public string LocalFormat { get; set; }

    [XmlElement("FraudScore")]
    public string FraudScore { get; set; }

    [XmlElement("Carrier")]
    public string Carrier { get; set; }

    [XmlElement("LineType")]
    public string LineType { get; set; }

    [XmlElement("Country")]
    public string Country { get; set; }

    [XmlElement("City")]
    public string City { get; set; }

    [XmlElement("ZipCode")]
    public string ZipCode { get; set; }

    [XmlElement("Region")]
    public string Region { get; set; }

    [XmlElement("DialingCode")]
    public string DialingCode { get; set; }

    [XmlElement("ActiveStatus")]
    public string ActiveStatus { get; set; }

    [XmlElement("UserActivity")]
    public string UserActivity { get; set; }

    [XmlElement("MNC")]
    public string MNC { get; set; }

    [XmlElement("MCC")]
    public string MCC { get; set; }

    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("TimeZone")]
    public string TimeZone { get; set; }

    [XmlElement("AssociatedEmailAddresses")]
    public associated_email_addresses AssociatedEmailAddresses { get; set; }

    [XmlElement("SMSDomain")]
    public string SMSDomain { get; set; }

    [XmlElement("SMSEmail")]
    public string SMSEmail { get; set; }

}