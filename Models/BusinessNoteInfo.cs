using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessNoteInfo")]
public class BusinessNoteInfo
{
    [XmlElement("Text")]
    public string Text { get; set; }

    [XmlElement("Notes")]
    public string Notes { get; set; }

}
}