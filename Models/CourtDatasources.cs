using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CourtDatasources")]
public class CourtDatasources
{
    [XmlElement("PublicRecordCriminalAndInfractions")]
    public string PublicRecordCriminalAndInfractions { get; set; }

    [XmlElement("PublicRecordUCCFilings")]
    public string PublicRecordUCCFilings { get; set; }

    [XmlElement("PublicRecordLawsuits")]
    public string PublicRecordLawsuits { get; set; }

    [XmlElement("PublicRecordLiensAndJudgments")]
    public string PublicRecordLiensAndJudgments { get; set; }

    [XmlElement("PublicRecordBankruptcy")]
    public string PublicRecordBankruptcy { get; set; }

    [XmlElement("PublicRecordSanctions")]
    public string PublicRecordSanctions { get; set; }

    [XmlElement("PublicRecordGlobalSanctions")]
    public string PublicRecordGlobalSanctions { get; set; }

    [XmlElement("WorldCheckRiskIntelligence")]
    public string WorldCheckRiskIntelligence { get; set; }

    [XmlElement("RealTimeIncarcerationAndArrests")]
    public string RealTimeIncarcerationAndArrests { get; set; }

    [XmlElement("PublicRecordDockets")]
    public string PublicRecordDockets { get; set; }

}