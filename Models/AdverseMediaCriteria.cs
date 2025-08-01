using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaCriteria")]
public class AdverseMediaCriteria
{
    [XmlElement("AdverseMediaSearchCriteria")]
    public AdverseMediaSearchCriteria AdverseMediaSearchCriteria { get; set; }
}
