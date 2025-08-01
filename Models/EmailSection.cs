using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EmailSection")]
public class EmailSection
{
    [XmlElement("EmailMultipleRecord")]
    public List<EmailMultipleRecord> EmailMultipleRecord { get; set; }

}