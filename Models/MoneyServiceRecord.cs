using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MoneyServiceRecord")]
public class MoneyServiceRecord
{
    [XmlElement("LegalName")]
    public string LegalName { get; set; }

    [XmlElement("BusinessAddress")]
    public CommonDataAddress BusinessAddress { get; set; }

    [XmlElement("ServicesProvided")]
    public ServicesProvided ServicesProvided { get; set; }

    [XmlElement("StateOffered")]
    public string StateOffered { get; set; }

    [XmlElement("NumberOfBranches")]
    public string NumberOfBranches { get; set; }

    [XmlElement("RegistrationFormReceived")]
    public string RegistrationFormReceived { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("DBAName")]
    public string DBAName { get; set; }

}
}