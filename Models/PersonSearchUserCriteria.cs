using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonSearchUserCriteria")]
public class PersonSearchUserCriteria
{
    [XmlElement("PersonCriteria")]
    public PersonCriteria PersonCriteria { get; set; }

}