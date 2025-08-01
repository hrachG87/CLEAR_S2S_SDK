using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DECorpResponseDetail")]
public class DECorpResponseDetail
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("FileNumber")]
    public string FileNumber { get; set; }

    [XmlElement("SearchType")]
    public string SearchType { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("GroupId")]
    public string GroupId { get; set; }

}
}