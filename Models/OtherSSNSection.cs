using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OtherSSNSection")]
public class OtherSSNSection
{
    [XmlElement("OtherSSNRecord")]
    public List<OtherSSNRecord> OtherSSNRecord { get; set; }

}