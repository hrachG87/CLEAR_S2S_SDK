using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RealPropertyDominantValuesContainer")]
public class RealPropertyDominantValuesContainer
{
    [XmlElement("RealPropertyDominantValues")]
    public RealPropertyDominantValues RealPropertyDominantValues { get; set; }

}