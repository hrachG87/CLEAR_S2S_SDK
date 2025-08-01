using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Contacts")]
public class Contacts
{
    [XmlElement("Contact")]
    public List<Contact> Contact { get; set; }

}