using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("LegalFilingsRecord")]
public class LegalFilingsRecord
{
    [XmlElement("Bankruptcies")]
    public LegalFilings Bankruptcies { get; set; }

    [XmlElement("TaxLiens")]
    public LegalFilings TaxLiens { get; set; }

    [XmlElement("Judgements")]
    public LegalFilings Judgements { get; set; }
}
