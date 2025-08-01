using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonDocumentUserCriteria")]
public class PersonDocumentUserCriteria
{
    [XmlElement("PersonDocumentCriteria")]
    public PersonDocumentCriteria PersonDocumentCriteria { get; set; }

}