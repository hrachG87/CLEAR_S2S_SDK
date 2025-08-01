using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OtherNamesforSSNSection")]
public class OtherNamesforSSNSection
{
    [XmlElement("OtherNameRecord")]
    public List<OtherNameRecord> OtherNameRecord { get; set; }

}