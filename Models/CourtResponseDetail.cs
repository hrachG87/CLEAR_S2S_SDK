using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CourtResponseDetail")]
public class CourtResponseDetail
{
    [XmlElement("CircuitCourtDocketRecord")]
    public List<CircuitCourtDocketRecord> CircuitCourtDocketRecord { get; set; }

    [XmlElement("CriminalExpansionRecord")]
    public List<CriminalExpansionRecord> CriminalExpansionRecord { get; set; }

    [XmlElement("DistrictCourtDocketRecord")]
    public List<DistrictCourtDocketRecord> DistrictCourtDocketRecord { get; set; }

    [XmlElement("FedDocketBankruptcyRecord")]
    public List<FedDocketBankruptcyRecord> FedDocketBankruptcyRecord { get; set; }

    [XmlElement("LienJudgeMultipleRecord")]
    public List<LienJudgeMultipleRecord> LienJudgeMultipleRecord { get; set; }

    [XmlElement("StateDocketRecord")]
    public List<StateDocketRecord> StateDocketRecord { get; set; }

    [XmlElement("WorldCheckRecord")]
    public List<WorldCheckRecord> WorldCheckRecord { get; set; }

    [XmlElement("GlobalSanctionRecord")]
    public List<GlobalSanctionRecord> GlobalSanctionRecord { get; set; }

    [XmlElement("HealthcareSanctionRecord")]
    public List<HealthcareSanctionRecord> HealthcareSanctionRecord { get; set; }

    [XmlElement("RealTimeArrestRecord")]
    public List<RealTimeArrestRecord> RealTimeArrestRecord { get; set; }

    [XmlElement("ArrestRecord")]
    public List<ArrestRecord> ArrestRecord { get; set; }

    [XmlElement("CriminalRecord")]
    public List<CriminalRecord> CriminalRecord { get; set; }

    [XmlElement("InfractionRecord")]
    public List<CriminalRecord> InfractionRecord { get; set; }

    [XmlElement("LienJudgeRecord")]
    public List<LienJudgeRecord> LienJudgeRecord { get; set; }

    [XmlElement("LienJudgeNYRecord")]
    public List<LienJudgeNYRecord> LienJudgeNYRecord { get; set; }

    [XmlElement("LowerCourtLawsuitRecord")]
    public List<LowerCourtLawsuitRecord> LowerCourtLawsuitRecord { get; set; }

    [XmlElement("LawsuitRecord")]
    public List<LawsuitRecord> LawsuitRecord { get; set; }

    [XmlElement("SuperiorBankruptcyRecord")]
    public List<SuperiorBankruptcyRecord> SuperiorBankruptcyRecord { get; set; }

    [XmlElement("PublicBankruptcyRecord")]
    public List<PublicBankruptcyRecord> PublicBankruptcyRecord { get; set; }

    [XmlElement("DocumentGuids")]
    public List<Sources> DocumentGuids { get; set; }

    [XmlElement("UCCRecord")]
    public List<UCCRecord> UCCRecord { get; set; }

    [XmlElement("UCCNYRecord")]
    public List<UCCNYRecord> UCCNYRecord { get; set; }

}