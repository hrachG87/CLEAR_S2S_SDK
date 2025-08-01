using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonAssociateAnalyticsResponseDetailContainer")]
public class PersonAssociateAnalyticsResponseDetailContainer
{
    [XmlElement("PersonAssociateAnalyticsResponseDetail")]
    public PersonAssociateAnalyticsResponseDetail PersonAssociateAnalyticsResponseDetail { get; set; }

}