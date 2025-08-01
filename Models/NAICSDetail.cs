using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("NAICSDetail")]
public class NAICSDetail
{
    [XmlElement("NAICSCode")]
    public string NAICSCode { get; set; }

    [XmlElement("NAICSDesc")]
    public string NAICSDesc { get; set; }

}
}