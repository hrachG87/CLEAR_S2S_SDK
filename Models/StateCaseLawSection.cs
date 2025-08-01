using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("StateCaseLawSection")]
public class StateCaseLawSection
{
    [XmlElement("StateCaseLawRecord")]
    public List<StateCaseLawRecord> StateCaseLawRecord { get; set; }

}