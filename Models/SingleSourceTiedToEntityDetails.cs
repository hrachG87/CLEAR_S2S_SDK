using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SingleSourceTiedToEntityDetails")]
public class SingleSourceTiedToEntityDetails
{
    [XmlElement("Source")]
    public string Source { get; set; }

}