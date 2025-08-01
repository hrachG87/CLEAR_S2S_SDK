using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessDominantValuesContainer")]
public class BusinessDominantValuesContainer
{
    [XmlElement("BusinessDominantValues")]
    public BusinessDominantValues BusinessDominantValues { get; set; }
}
