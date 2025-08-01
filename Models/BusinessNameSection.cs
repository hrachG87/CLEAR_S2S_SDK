using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessNameSection")]
public class BusinessNameSection
{
    [XmlElement("BusinessNameRecord")]
    public List<BusinessNameRecord> BusinessNameRecord { get; set; }

}