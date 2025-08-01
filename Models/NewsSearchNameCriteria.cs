using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("NewsSearchNameCriteria")]
public class NewsSearchNameCriteria
{
    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

}