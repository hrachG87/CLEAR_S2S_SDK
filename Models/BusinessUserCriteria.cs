using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessUserCriteria")]
public class BusinessUserCriteria
{
    [XmlElement("BusinessCriteria")]
    public BusinessCriteria BusinessCriteria { get; set; }
}
