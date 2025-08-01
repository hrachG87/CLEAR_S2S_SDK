using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonPermissiblePurposeSection")]
public class PersonPermissiblePurposeSection
{
    [XmlElement("Purpose")]
    public List<PersonPurpose> Purpose { get; set; }
}
