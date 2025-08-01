using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Name")]
public class Name
{
    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

}