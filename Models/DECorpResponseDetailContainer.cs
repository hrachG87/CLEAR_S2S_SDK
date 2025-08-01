using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DECorpResponseDetailContainer")]
public class DECorpResponseDetailContainer
{
    [XmlElement("DECorpResponseDetail")]
    public DECorpResponseDetail DECorpResponseDetail { get; set; }

}
}