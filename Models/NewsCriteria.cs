using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("NewsCriteria")]
public class NewsCriteria
{
    [XmlElement("NewsSearchCriteria")]
    public NewsSearchCriteria NewsSearchCriteria { get; set; }

}