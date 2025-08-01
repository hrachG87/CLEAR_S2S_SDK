using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformSyntheticIDDetails")]
public class RiskInformSyntheticIDDetails
{
    [XmlElement("syntheticIDRecord")]
    public SyntheticIDRecord syntheticIDRecord { get; set; }

}