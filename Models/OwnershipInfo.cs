using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OwnershipInfo")]
public class OwnershipInfo
{
    [XmlElement("AbsenteeIndicator")]
    public string AbsenteeIndicator { get; set; }

    [XmlElement("AbsenteeOwnerName")]
    public string AbsenteeOwnerName { get; set; }

    [XmlElement("CoOwner")]
    public List<GroupOwnerInfo> CoOwner { get; set; }

    [XmlElement("CorpOwnedIndicator")]
    public string CorpOwnedIndicator { get; set; }

    [XmlElement("OtherOwnersIndicator")]
    public string OtherOwnersIndicator { get; set; }

    [XmlElement("Owner")]
    public GroupOwnerInfo Owner { get; set; }

    [XmlElement("PartialInterestIndicator")]
    public string PartialInterestIndicator { get; set; }

}