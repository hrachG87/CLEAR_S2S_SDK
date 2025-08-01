using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyAssociateAnalyticsResponseDetailContainer")]
public class CompanyAssociateAnalyticsResponseDetailContainer
{
    [XmlElement("CompanyAssociateAnalyticsResponseDetail")]
    public CompanyAssociateAnalyticsResponseDetail CompanyAssociateAnalyticsResponseDetail { get; set; }

}