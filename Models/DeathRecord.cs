using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DeathRecord")]
public class DeathRecord
{
    [XmlElement("DeathVerification")]
    public string DeathVerification { get; set; }

    [XmlElement("LastAddress")]
    public CommonDataAddress LastAddress { get; set; }

    [XmlElement("PaymentAddress")]
    public CommonDataAddress PaymentAddress { get; set; }

    [XmlElement("PersonInfo")]
    public PersonInfo PersonInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}
}