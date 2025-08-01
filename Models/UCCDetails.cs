using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("UCCDetails")]
public class UCCDetails
{
    [XmlElement("UCCDetail")]
    public List<UCCDetail> UCCDetail { get; set; }

}