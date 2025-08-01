using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformNewsDetails")]
public class RiskInformNewsDetails
{
    [XmlElement("NewsRecord")]
    public List<NewsResults> NewsRecord { get; set; }

}
}