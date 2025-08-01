using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyAssociateAnalyticsResponseDetailContainer")]
public class CompanyAssociateAnalyticsResponseDetailContainer
{
    [XmlElement("CompanyAssociateAnalyticsResponseDetail")]
    public CompanyAssociateAnalyticsResponseDetail CompanyAssociateAnalyticsResponseDetail { get; set; }

}
}