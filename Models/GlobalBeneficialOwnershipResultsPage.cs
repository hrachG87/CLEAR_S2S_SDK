using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GlobalBeneficialOwnershipResultsPage")]
public class GlobalBeneficialOwnershipResultsPage
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("StartIndex")]
    public int StartIndex { get; set; }

    [XmlElement("EndIndex")]
    public int EndIndex { get; set; }

    [XmlElement("ResultGroup")]
    public List<GlobalBeneficialOwnershipSearchResultsGroup> ResultGroup { get; set; }

}