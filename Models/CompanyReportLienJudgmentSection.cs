using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportLienJudgmentSection")]
public class CompanyReportLienJudgmentSection
{
    [XmlElement("LienJudgeRecord")]
    public List<LienJudgeRecord> LienJudgeRecord { get; set; }

    [XmlElement("LienJudgeNYRecord")]
    public List<LienJudgeNYRecord> LienJudgeNYRecord { get; set; }

    [XmlElement("LienJudgeMultipleRecord")]
    public List<LienJudgeMultipleRecord> LienJudgeMultipleRecord { get; set; }

}
}