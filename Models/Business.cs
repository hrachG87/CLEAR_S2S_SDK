using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Business")]
public class Business
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }

}
}