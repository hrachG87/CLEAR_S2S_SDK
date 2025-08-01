using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DetailResult")]
public class DetailResult
{
    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("AlertSubjects")]
    public AlertSubjects AlertSubjects { get; set; }

    [XmlElement("CategoryTags")]
    public CategoryTags CategoryTags { get; set; }

    [XmlElement("SanctionOverrideList")]
    public SanctionOverrideList SanctionOverrideList { get; set; }

}