using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("MoneyServiceBusinessSection")]
public class MoneyServiceBusinessSection
{
    [XmlElement("MoneyServiceRecord")]
    public List<MoneyServiceRecord> MoneyServiceRecord { get; set; }

}