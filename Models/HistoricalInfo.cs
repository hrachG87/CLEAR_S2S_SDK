using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("HistoricalInfo")]
public class HistoricalInfo
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("OperatingCompany")]
    public OperatingCompany OperatingCompany { get; set; }

}
}