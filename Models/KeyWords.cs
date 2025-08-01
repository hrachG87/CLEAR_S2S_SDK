using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("KeyWords")]
public class KeyWords
{
    [XmlElement("KeyWordText")]
    public List<string> KeyWordText { get; set; }

}
}