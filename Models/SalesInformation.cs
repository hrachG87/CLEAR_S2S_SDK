using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SalesInformation")]
public class SalesInformation
{
    [XmlElement("AnnualSalesUS")]
    public string AnnualSalesUS { get; set; }

    [XmlElement("AnnualSalesLocal")]
    public string AnnualSalesLocal { get; set; }

}
}