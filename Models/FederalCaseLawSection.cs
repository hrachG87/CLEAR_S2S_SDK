using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FederalCaseLawSection")]
public class FederalCaseLawSection
{
    [XmlElement("FederalCaseLawRecord")]
    public List<FederalCaseLawRecord> FederalCaseLawRecord { get; set; }

}