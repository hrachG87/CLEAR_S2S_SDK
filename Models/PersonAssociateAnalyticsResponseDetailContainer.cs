using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonAssociateAnalyticsResponseDetailContainer")]
public class PersonAssociateAnalyticsResponseDetailContainer
{
    [XmlElement("PersonAssociateAnalyticsResponseDetail")]
    public PersonAssociateAnalyticsResponseDetail PersonAssociateAnalyticsResponseDetail { get; set; }

}
}