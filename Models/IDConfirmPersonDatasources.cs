using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("IDConfirmPersonDatasources")]
public class IDConfirmPersonDatasources
{
    [XmlElement("PhoneAttributes")]
    public string PhoneAttributes { get; set; }

    [XmlElement("EmailAttributes")]
    public string EmailAttributes { get; set; }

}