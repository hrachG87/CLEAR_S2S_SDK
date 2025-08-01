using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UCCDetails")]
public class UCCDetails
{
    [XmlElement("UCCDetail")]
    public List<UCCDetail> UCCDetail { get; set; }

}
}