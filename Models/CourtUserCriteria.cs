using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtUserCriteria")]
public class CourtUserCriteria
{
    [XmlElement("CourtCriteria")]
    public CourtCriteria CourtCriteria { get; set; }

}
}