using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("UtilitySection")]
public class UtilitySection
{
    [XmlElement("UtilityRecord")]
    public List<UtilityRecord> UtilityRecord { get; set; }

}