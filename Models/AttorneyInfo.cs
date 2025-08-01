using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AttorneyInfo")]
public class AttorneyInfo
{
    [XmlElement("AttorneyBarNumber")]
    public string AttorneyBarNumber { get; set; }

    [XmlElement("AttorneyCOR")]
    public string AttorneyCOR { get; set; }

    [XmlElement("AttorneyEmail")]
    public string AttorneyEmail { get; set; }

    [XmlElement("AttornyForeignRegistration")]
    public string AttornyForeignRegistration { get; set; }

    [XmlElement("AttorneyFTS")]
    public string AttorneyFTS { get; set; }

    [XmlElement("AttorneyID")]
    public string AttorneyID { get; set; }

    [XmlElement("AttorneyLicense")]
    public string AttorneyLicense { get; set; }

    [XmlElement("AttorneyName")]
    public List<string> AttorneyName { get; set; }

    [XmlElement("AttorneyPhone")]
    public string AttorneyPhone { get; set; }

    [XmlElement("AttorneyFax")]
    public string AttorneyFax { get; set; }

    [XmlElement("AttorneyAddress")]
    public List<CommonDataAddress> AttorneyAddress { get; set; }

    [XmlElement("AttorneyRepresents")]
    public string AttorneyRepresents { get; set; }

    [XmlElement("AttorneyRole")]
    public string AttorneyRole { get; set; }

    [XmlElement("AttorneyStatus")]
    public string AttorneyStatus { get; set; }

    [XmlElement("AttorneyTerminatedDate")]
    public string AttorneyTerminatedDate { get; set; }

    [XmlElement("TypeofAttorney")]
    public string TypeofAttorney { get; set; }

    [XmlElement("FirmName")]
    public string FirmName { get; set; }

    [XmlElement("FirmStatus")]
    public string FirmStatus { get; set; }

}
}