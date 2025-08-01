using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SingleSourceTiedToEntityDetails")]
public class SingleSourceTiedToEntityDetails
{
    [XmlElement("Source")]
    public string Source { get; set; }

}
}