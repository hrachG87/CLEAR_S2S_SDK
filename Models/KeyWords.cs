using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("KeyWords")]
public class KeyWords
{
    [XmlElement("KeyWordText")]
    public List<string> KeyWordText { get; set; }
}
