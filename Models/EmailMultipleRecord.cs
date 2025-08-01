using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EmailMultipleRecord")]
public class EmailMultipleRecord
{
    [XmlElement("EmailInfo")]
    public EmailInfo EmailInfo { get; set; }

}