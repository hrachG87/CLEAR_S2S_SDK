using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("TaxSection")]
public class TaxSection
{
    [XmlElement("TaxInfoRecord")]
    public List<TaxInfoRecord> TaxInfoRecord { get; set; }

}
}