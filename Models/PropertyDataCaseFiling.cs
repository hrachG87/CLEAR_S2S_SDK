using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PropertyDataCaseFiling")]
public class PropertyDataCaseFiling
{
    [XmlElement("FileNumber")]
    public string FileNumber { get; set; }

    [XmlElement("FileDate")]
    public string FileDate { get; set; }

}