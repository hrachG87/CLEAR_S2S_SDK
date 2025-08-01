using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportMarijuanaRelatedBusinessesSection")]
public class PersonReportMarijuanaRelatedBusinessesSection
{
    [XmlElement("MarijuanaRelatedBusinessRecord")]
    public List<MarijuanaRelatedBusinessRecord> MarijuanaRelatedBusinessRecord { get; set; }

}
}