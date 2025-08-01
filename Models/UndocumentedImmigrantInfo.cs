using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("UndocumentedImmigrantInfo")]
public class UndocumentedImmigrantInfo
{
    [XmlElement("UndocumentedImmigrantName")]
    public string UndocumentedImmigrantName { get; set; }

    [XmlElement("UndocumentedImmigrantID")]
    public string UndocumentedImmigrantID { get; set; }

}