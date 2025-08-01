using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RealPropertyRecordDetailsContainer")]
public class RealPropertyRecordDetailsContainer
{
    [XmlElement("RealPropertyResponseDetail")]
    public RealPropertyResponseDetail RealPropertyResponseDetail { get; set; }

}
}