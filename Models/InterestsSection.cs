using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("InterestsSection")]
public class InterestsSection
{
    [XmlElement("InterestsRecord")]
    public List<InterestInfo> InterestsRecord { get; set; }

}