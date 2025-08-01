using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DMVInfo")]
public class DMVInfo
{
    [XmlElement("MailingAddress")]
    public List<CommonDataAddress> MailingAddress { get; set; }

    [XmlElement("PersonInfo")]
    public PersonProfile PersonInfo { get; set; }

    [XmlElement("PhysicalAddress")]
    public List<CommonDataAddress> PhysicalAddress { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

}
}