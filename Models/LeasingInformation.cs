using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LeasingInformation")]
public class LeasingInformation
{
    [XmlElement("LeasingDetails")]
    public List<LeasingDetails> LeasingDetails { get; set; }

}