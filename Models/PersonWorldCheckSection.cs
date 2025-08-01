using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonWorldCheckSection")]
public class PersonWorldCheckSection
{
    [XmlElement("worldCheckRecord")]
    public List<WorldCheckRecord> worldCheckRecord { get; set; }

}