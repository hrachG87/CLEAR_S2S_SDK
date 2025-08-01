using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EmailMultipleRecord")]
public class EmailMultipleRecord
{
    [XmlElement("EmailInfo")]
    public EmailInfo EmailInfo { get; set; }

}
}