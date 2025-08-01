using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WorldbaseSection")]
public class WorldbaseSection
{
    [XmlElement("WorldbaseRecord")]
    public List<WorldbaseRecord> WorldbaseRecord { get; set; }

}