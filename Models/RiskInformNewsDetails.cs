using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformNewsDetails")]
public class RiskInformNewsDetails
{
    [XmlElement("NewsRecord")]
    public List<NewsResults> NewsRecord { get; set; }

}