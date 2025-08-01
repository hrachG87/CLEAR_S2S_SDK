using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessProfileSection")]
public class BusinessProfileSection
{
    [XmlElement("BusinessProfileRecord")]
    public List<BusinessProfileRecord> BusinessProfileRecord { get; set; }

}