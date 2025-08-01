using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EmailSection")]
public class EmailSection
{
    [XmlElement("EmailMultipleRecord")]
    public List<EmailMultipleRecord> EmailMultipleRecord { get; set; }

}
}