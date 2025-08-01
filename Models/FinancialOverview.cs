using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FinancialOverview")]
public class FinancialOverview
{
    [XmlElement("CurrentAssets")]
    public Assets CurrentAssets { get; set; }

    [XmlElement("NonCurrentAssets")]
    public Assets NonCurrentAssets { get; set; }

    [XmlElement("CurrentLiabilities")]
    public Liabilities CurrentLiabilities { get; set; }

    [XmlElement("NonCurrentLiabilities")]
    public Liabilities NonCurrentLiabilities { get; set; }

    [XmlElement("ProfLossReconcilationInfo")]
    public string ProfLossReconcilationInfo { get; set; }

    [XmlElement("SourceFiguresInfo")]
    public string SourceFiguresInfo { get; set; }

    [XmlElement("AccountantOpinion")]
    public List<string> AccountantOpinion { get; set; }

}