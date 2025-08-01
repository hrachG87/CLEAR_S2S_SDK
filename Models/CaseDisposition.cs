using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CaseDisposition")]
public class CaseDisposition
{
    [XmlElement("DecisionCategory")]
    public string DecisionCategory { get; set; }

    [XmlElement("Decision")]
    public string Decision { get; set; }

    [XmlElement("FinalDate")]
    public string FinalDate { get; set; }

    [XmlElement("Disposition")]
    public string Disposition { get; set; }

    [XmlElement("DispositionDate")]
    public string DispositionDate { get; set; }
}
