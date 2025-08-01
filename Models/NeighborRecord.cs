using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("NeighborRecord")]
public class NeighborRecord
{
    [XmlElement("SubjectAddress")]
    public CommonDataAddress SubjectAddress { get; set; }

    [XmlElement("NeighborInfo")]
    public List<PersonReportAddressInfo> NeighborInfo { get; set; }

}
}