using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ResultsFilter")]
public class ResultsFilter
{
    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("Keywords")]
    public string Keywords { get; set; }

    [XmlElement("DateRange")]
    public DateRange DateRange { get; set; }

    [XmlElement("ScoreRange")]
    public ScoreRange ScoreRange { get; set; }

    [XmlElement("CategoryTags")]
    public CategoryTags CategoryTags { get; set; }

}
}