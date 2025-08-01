using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ComplaintCharges")]
public class ComplaintCharges
{
    [XmlElement("NumberOfCounts")]
    public string NumberOfCounts { get; set; }

    [XmlElement("Disposition")]
    public List<CaseDisposition> Disposition { get; set; }

}