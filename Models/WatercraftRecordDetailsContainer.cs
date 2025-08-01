using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WatercraftRecordDetailsContainer")]
public class WatercraftRecordDetailsContainer
{
    [XmlElement("WatercraftResponseDetail")]
    public WatercraftResponseDetail WatercraftResponseDetail { get; set; }

}
}