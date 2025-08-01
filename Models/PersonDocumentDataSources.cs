using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonDocumentDataSources")]
public class PersonDocumentDataSources
{
    [XmlElement("PublicRecordPeople")]
    public string PublicRecordPeople { get; set; }

    [XmlElement("WorldCheckRiskIntelligence")]
    public string WorldCheckRiskIntelligence { get; set; }

    [XmlElement("WorkAffiliations")]
    public string WorkAffiliations { get; set; }

    [XmlElement("NPIRecord")]
    public string NPIRecord { get; set; }

}