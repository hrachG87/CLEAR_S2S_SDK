using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("NeighborRecord")]
public class NeighborRecord
{
    [XmlElement("SubjectAddress")]
    public CommonDataAddress SubjectAddress { get; set; }

    [XmlElement("NeighborInfo")]
    public List<PersonReportAddressInfo> NeighborInfo { get; set; }
}
