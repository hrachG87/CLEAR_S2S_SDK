using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EidvBusinessSearchMatchTypeField")]
public class EidvBusinessSearchMatchTypeField
{
    [XmlElement("value")]
    public string value { get; set; }

    [XmlElement("matchtype")]
    public string matchtype { get; set; }

    [XmlElement("matchscore")]
    public string matchscore { get; set; }

}
}