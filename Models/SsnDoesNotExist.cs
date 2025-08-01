using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SsnDoesNotExist")]
public class SsnDoesNotExist
{
    [XmlElement("SsnDoesNotExistIndicator")]
    public string SsnDoesNotExistIndicator { get; set; }

    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

}
}