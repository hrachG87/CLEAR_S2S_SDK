using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FcraSection")]
public class FcraSection
{
    [XmlElement("DisclaimerText")]
    public string DisclaimerText { get; set; }

}