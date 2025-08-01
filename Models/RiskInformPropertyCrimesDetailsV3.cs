using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformPropertyCrimesDetailsV3")]
public class RiskInformPropertyCrimesDetailsV3
{
    [XmlElement("propertyCrimesRecord")]
    public CriminalRecordInfoV3 propertyCrimesRecord { get; set; }

}