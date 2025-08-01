using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Photos")]
public class Photos
{
    [XmlElement("PhotoURL")]
    public string PhotoURL { get; set; }

    [XmlElement("PhotoDate")]
    public string PhotoDate { get; set; }

}