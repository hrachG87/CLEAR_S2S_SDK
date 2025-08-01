using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("StateOwnedEntitySection")]
public class StateOwnedEntitySection
{
    [XmlElement("SoeRecord")]
    public List<SoeRecord> SoeRecord { get; set; }

}