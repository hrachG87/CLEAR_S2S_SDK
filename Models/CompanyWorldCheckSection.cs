using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyWorldCheckSection")]
public class CompanyWorldCheckSection
{
    [XmlElement("WorldCheckRecord")]
    public List<WorldCheckRecord> WorldCheckRecord { get; set; }

}