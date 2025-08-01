using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtRecordDetailsContainer")]
public class CourtRecordDetailsContainer
{
    [XmlElement("CourtResponseDetail")]
    public CourtResponseDetail CourtResponseDetail { get; set; }

}
}