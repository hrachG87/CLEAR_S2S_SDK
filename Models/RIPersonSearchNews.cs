using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIPersonSearchNews")]
public class RIPersonSearchNews
{
    [XmlElement("NewsResult")]
    public List<RIPersonSearchNewsResult> NewsResult { get; set; }

}