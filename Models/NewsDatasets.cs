using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("NewsDatasets")]
public class NewsDatasets
{
    [XmlElement("AllNews")]
    public bool AllNews { get; set; }

    [XmlElement("NegativeNews")]
    public bool NegativeNews { get; set; }

    [XmlElement("ObituaryNews")]
    public bool ObituaryNews { get; set; }

}
}