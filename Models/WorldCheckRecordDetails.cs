using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WorldCheckRecordDetails")]
public class WorldCheckRecordDetails
{
    [XmlElement("worldCheckDocumentResponseDetail")]
    public WorldCheckDocumentResponseDetail worldCheckDocumentResponseDetail { get; set; }
}
