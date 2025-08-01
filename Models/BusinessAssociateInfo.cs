using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessAssociateInfo")]
public class BusinessAssociateInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("PersonalProfile")]
    public PersonProfile PersonalProfile { get; set; }

}