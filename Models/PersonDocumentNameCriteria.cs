using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonDocumentNameCriteria")]
public class PersonDocumentNameCriteria
{
    [XmlElement("AdvancedNameSearch")]
    public PersonDocumentAdvancedNamePersonSearch AdvancedNameSearch { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("MiddleInitial")]
    public string MiddleInitial { get; set; }

    [XmlElement("SecondaryLastName")]
    public string SecondaryLastName { get; set; }

    [XmlElement("PersonRole")]
    public string PersonRole { get; set; }
}
