using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("VoterRecord")]
public class VoterRecord
{
    [XmlElement("PersonAddress")]
    public CommonDataAddress PersonAddress { get; set; }

    [XmlElement("LastVoteDate")]
    public string LastVoteDate { get; set; }

    [XmlElement("MailingAddress")]
    public CommonDataAddress MailingAddress { get; set; }

    [XmlElement("MotorNumber")]
    public string MotorNumber { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("PoliticalParty")]
    public string PoliticalParty { get; set; }

    [XmlElement("RegistrationDate")]
    public string RegistrationDate { get; set; }

    [XmlElement("VoterHistory")]
    public List<string> VoterHistory { get; set; }

    [XmlElement("VoterIDNumber")]
    public string VoterIDNumber { get; set; }

    [XmlElement("EmployeeOccupation")]
    public string EmployeeOccupation { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}
}