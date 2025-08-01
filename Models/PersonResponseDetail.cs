using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonResponseDetail")]
public class PersonResponseDetail
{
    [XmlElement("Name")]
    public PersonName Name { get; set; }

    [XmlElement("SSN")]
    public List<string> SSN { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("DriverLicenseInfo")]
    public List<DriverLicenseInfo> DriverLicenseInfo { get; set; }

    [XmlElement("EmailAddress")]
    public List<string> EmailAddress { get; set; }

    [XmlElement("Employer")]
    public List<string> Employer { get; set; }

    [XmlElement("KnownAddresses")]
    public List<PersonSearchAddressInfo> KnownAddresses { get; set; }

    [XmlElement("AdditionalPhoneNumbers")]
    public List<AdditionalPhoneNumbers> AdditionalPhoneNumbers { get; set; }

    [XmlElement("Message")]
    public string Message { get; set; }

    [XmlElement("PhotoImages")]
    public PersonSearchPhotoImages PhotoImages { get; set; }

    [XmlElement("PersonEntityId")]
    public string PersonEntityId { get; set; }

    [XmlElement("PersonTREntityId")]
    public string PersonTREntityId { get; set; }

    [XmlElement("AllSourceDocuments")]
    public List<PersonSearchSources> AllSourceDocuments { get; set; }

    [XmlElement("ExperianGatewayRecord")]
    public ExperianRealTimeRecord ExperianGatewayRecord { get; set; }

    [XmlElement("AKANames")]
    public List<PersonName> AKANames { get; set; }

    [XmlElement("NPINumber")]
    public string NPINumber { get; set; }

}
}