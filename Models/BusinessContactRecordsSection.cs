using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessContactRecordsSection")]
public class BusinessContactRecordsSection
{
    [XmlElement("BusinessContactRecord")]
    public List<BusinessContactRecord> BusinessContactRecord { get; set; }

}