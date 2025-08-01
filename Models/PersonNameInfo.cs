using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonNameInfo")]
public class PersonNameInfo
{
    [XmlElement("Name")]
    public PersonName Name { get; set; }

}