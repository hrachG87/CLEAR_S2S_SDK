using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FictitiousBusinessNameSection")]
public class FictitiousBusinessNameSection
{
    [XmlElement("FictitiousBusinessRecord")]
    public List<FictitiousBusinessRecord> FictitiousBusinessRecord { get; set; }

}
}