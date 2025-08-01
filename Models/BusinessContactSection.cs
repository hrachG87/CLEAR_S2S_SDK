using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessContactSection")]
public class BusinessContactSection
{
    [XmlElement("BusinessContactRecord")]
    public List<BusinessContactRecord> BusinessContactRecord { get; set; }

}