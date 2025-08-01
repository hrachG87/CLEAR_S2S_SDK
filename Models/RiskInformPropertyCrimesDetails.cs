using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformPropertyCrimesDetails")]
public class RiskInformPropertyCrimesDetails
{
    [XmlElement("propertyCrimesRecord")]
    public CriminalRecordInfo propertyCrimesRecord { get; set; }
}
