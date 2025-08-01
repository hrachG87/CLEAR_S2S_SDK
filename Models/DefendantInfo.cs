using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DefendantInfo")]
public class DefendantInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("AdmissionInfo")]
    public AdmissionInfo AdmissionInfo { get; set; }

    [XmlElement("HistoricalAddress")]
    public List<CommonDataAddress> HistoricalAddress { get; set; }

    [XmlElement("MiscellaneousInfo")]
    public List<string> MiscellaneousInfo { get; set; }

    [XmlElement("PersonInfo")]
    public CriminalPersonInfo PersonInfo { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("RelativeInfo")]
    public List<CriminalRelativeInfo> RelativeInfo { get; set; }

    [XmlElement("IDInfo")]
    public IDInfo IDInfo { get; set; }

}
}