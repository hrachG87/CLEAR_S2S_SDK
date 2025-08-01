using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WatercraftRecordDetailsContainer")]
public class WatercraftRecordDetailsContainer
{
    [XmlElement("WatercraftResponseDetail")]
    public WatercraftResponseDetail WatercraftResponseDetail { get; set; }

}