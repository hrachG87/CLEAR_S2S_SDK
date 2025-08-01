using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonReportCustomDetails")]
public class RIPersonReportCustomDetails
{
    [XmlElement("customRecord")]
    public CriminalRecordInfo customRecord { get; set; }

}
}