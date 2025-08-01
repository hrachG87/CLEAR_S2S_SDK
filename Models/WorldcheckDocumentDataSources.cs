using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WorldcheckDocumentDataSources")]
public class WorldcheckDocumentDataSources
{
    [XmlElement("WorldCheckRiskIntelligence")]
    public string WorldCheckRiskIntelligence { get; set; }
}
