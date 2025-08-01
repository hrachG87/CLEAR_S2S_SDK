using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessDocumentDatasources")]
public class BusinessDocumentDatasources
{
    [XmlElement("PublicRecordBusiness")]
    public string PublicRecordBusiness { get; set; }

    [XmlElement("WorldCheckRiskIntelligence")]
    public string WorldCheckRiskIntelligence { get; set; }

    [XmlElement("PublicRecordInfractions")]
    public string PublicRecordInfractions { get; set; }

    [XmlElement("PublicRecordGlobalSanctions")]
    public string PublicRecordGlobalSanctions { get; set; }

    [XmlElement("Worldbase")]
    public string Worldbase { get; set; }

    [XmlElement("NPIRecord")]
    public string NPIRecord { get; set; }
}
