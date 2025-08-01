using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PossiblyRelatedSources")]
public class PossiblyRelatedSources
{
    [XmlElement("Image")]
    public string Image { get; set; }

    [XmlElement("PreviewText")]
    public string PreviewText { get; set; }

    [XmlElement("URL")]
    public string URL { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("FriendlyURL")]
    public string FriendlyURL { get; set; }

}
}