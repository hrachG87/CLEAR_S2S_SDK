using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AssociateNameInfo")]
public class AssociateNameInfo
{
    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

}