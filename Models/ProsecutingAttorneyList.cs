using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ProsecutingAttorneyList")]
public class ProsecutingAttorneyList
{
    [XmlElement("ProsecutingAgency")]
    public string ProsecutingAgency { get; set; }

    [XmlElement("AttorneyInfo")]
    public AttorneyInfo AttorneyInfo { get; set; }

    [XmlElement("AttorneyAddress")]
    public CommonDataAddress AttorneyAddress { get; set; }

}
}