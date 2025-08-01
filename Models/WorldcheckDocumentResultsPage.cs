using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WorldcheckDocumentResultsPage")]
public class WorldcheckDocumentResultsPage
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("StartIndex")]
    public int StartIndex { get; set; }

    [XmlElement("EndIndex")]
    public int EndIndex { get; set; }

    [XmlElement("ResultGroup")]
    public List<WorldCheckSearchResultsGroup> ResultGroup { get; set; }
}
