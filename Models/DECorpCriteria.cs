using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DECorpCriteria")]
public class DECorpCriteria
{
    [XmlElement("DECorpSearchCriteria")]
    public DECorpSearchCriteria DECorpSearchCriteria { get; set; }
}
