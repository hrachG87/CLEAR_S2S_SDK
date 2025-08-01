using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ForeignIncInfo")]
public class ForeignIncInfo
{
    [XmlElement("ForeignIncorporationDate")]
    public string ForeignIncorporationDate { get; set; }

    [XmlElement("OriginalForeignKind")]
    public string OriginalForeignKind { get; set; }

    [XmlElement("OriginalForeignName")]
    public string OriginalForeignName { get; set; }

    [XmlElement("OriginalState")]
    public string OriginalState { get; set; }

}
}