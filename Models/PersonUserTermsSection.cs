using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonUserTermsSection")]
public class PersonUserTermsSection
{
    [XmlElement("UserTermRecord")]
    public PersonUserTermRecord UserTermRecord { get; set; }
}
