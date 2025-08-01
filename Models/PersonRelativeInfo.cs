using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonRelativeInfo")]
public class PersonRelativeInfo
{
    [XmlElement("PersonInfo")]
    public PersonReportPersonInfo PersonInfo { get; set; }

    [XmlElement("EntityId")]
    public string EntityId { get; set; }

    [XmlElement("RelativeOf")]
    public RelativeOf RelativeOf { get; set; }

    [XmlElement("RelativeAKA")]
    public List<PersonReportPersonInfo> RelativeAKA { get; set; }

    [XmlElement("AddressInfo")]
    public List<PersonReportAddressInfo> AddressInfo { get; set; }

    [XmlElement("TREntityId")]
    public string TREntityId { get; set; }

}