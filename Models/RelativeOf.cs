using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RelativeOf")]
public class RelativeOf
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("RelativeDegree")]
    public string RelativeDegree { get; set; }

}
}