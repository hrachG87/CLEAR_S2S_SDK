using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("HistoricBusinessAffiliationInfo")]
public class HistoricBusinessAffiliationInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("HistoryChangeDate")]
    public string HistoryChangeDate { get; set; }

    [XmlElement("PreviousBusinessAffilation")]
    public string PreviousBusinessAffilation { get; set; }

}
}