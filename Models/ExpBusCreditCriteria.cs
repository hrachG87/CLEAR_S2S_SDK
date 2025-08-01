using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ExpBusCreditCriteria")]
public class ExpBusCreditCriteria
{
    [XmlElement("ExpBusCreditSearchCriteria")]
    public ExpBusCreditSearchCriteria ExpBusCreditSearchCriteria { get; set; }
}
