using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportCorporateSection")]
public class PersonReportCorporateSection
{
    [XmlElement("CorporateRecord")]
    public List<CorporateRecord> CorporateRecord { get; set; }

}
}