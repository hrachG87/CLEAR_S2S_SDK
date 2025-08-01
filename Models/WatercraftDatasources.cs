using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WatercraftDatasources")]
public class WatercraftDatasources
{
    [XmlElement("PublicRecordWatercraft")]
    public string PublicRecordWatercraft { get; set; }
}
