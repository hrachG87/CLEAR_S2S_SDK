using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MainArticle")]
public class MainArticle
{
    [XmlElement("DateLine")]
    public List<string> DateLine { get; set; }

    [XmlElement("LeadParagraph")]
    public List<string> LeadParagraph { get; set; }

    [XmlElement("BodyText")]
    public List<BodyText> BodyText { get; set; }

}
}