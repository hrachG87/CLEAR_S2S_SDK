using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessNameSection")]
public class BusinessNameSection
{
    [XmlElement("BusinessNameRecord")]
    public List<BusinessNameRecord> BusinessNameRecord { get; set; }

}
}