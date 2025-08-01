using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("IDConfirmBusinessDatasources")]
public class IDConfirmBusinessDatasources
{
    [XmlElement("PhoneAttributes")]
    public string PhoneAttributes { get; set; }

}