using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PropertyOwnerSection")]
public class PropertyOwnerSection
{
    [XmlElement("PropertyOwnerRecord")]
    public List<PropertyOwnerRecord> PropertyOwnerRecord { get; set; }

}