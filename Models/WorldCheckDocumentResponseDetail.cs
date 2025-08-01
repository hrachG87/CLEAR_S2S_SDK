using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WorldCheckDocumentResponseDetail")]
public class WorldCheckDocumentResponseDetail
{
    [XmlElement("WorldCheckRecord")]
    public List<WorldCheckRecord> WorldCheckRecord { get; set; }

    [XmlElement("DocumentGuids")]
    public List<Sources> DocumentGuids { get; set; }

}