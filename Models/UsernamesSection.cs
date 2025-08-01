using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("UsernamesSection")]
public class UsernamesSection
{
    [XmlElement("UsernamesRecord")]
    public List<UsernameInfo> UsernamesRecord { get; set; }

}