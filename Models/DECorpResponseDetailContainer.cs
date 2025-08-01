using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DECorpResponseDetailContainer")]
public class DECorpResponseDetailContainer
{
    [XmlElement("DECorpResponseDetail")]
    public DECorpResponseDetail DECorpResponseDetail { get; set; }

}