using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("KnownEmailAddresses")]
public class KnownEmailAddresses
{
    [XmlElement("KnownEmailAddress")]
    public List<KnownEmailAddress> KnownEmailAddress { get; set; }

}