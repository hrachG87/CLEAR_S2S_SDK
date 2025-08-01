using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("OwnerInfo")]
public class OwnerInfo
{
    [XmlElement("MailingAddress")]
    public List<CommonDataAddress> MailingAddress { get; set; }

    [XmlElement("OwnerType")]
    public string OwnerType { get; set; }

    [XmlElement("PersonInfo")]
    public PersonProfile PersonInfo { get; set; }

    [XmlElement("PhysicalAddress")]
    public List<CommonDataAddress> PhysicalAddress { get; set; }

    [XmlElement("VehicleInfo")]
    public VehicleInfo VehicleInfo { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }
}
