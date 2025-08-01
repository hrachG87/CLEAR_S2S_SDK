using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("TaxAssessorInfo")]
public class TaxAssessorInfo
{
    [XmlElement("AppraisedValues")]
    public Valuations AppraisedValues { get; set; }

    [XmlElement("AssessedValues")]
    public Valuations AssessedValues { get; set; }

    [XmlElement("CalculatedValues")]
    public Valuations CalculatedValues { get; set; }

    [XmlElement("EstimatedTaxYear")]
    public string EstimatedTaxYear { get; set; }

    [XmlElement("MarketValues")]
    public Valuations MarketValues { get; set; }

    [XmlElement("TaxAmount")]
    public string TaxAmount { get; set; }

    [XmlElement("TaxCodeArea")]
    public string TaxCodeArea { get; set; }

    [XmlElement("TaxYear")]
    public string TaxYear { get; set; }

    [XmlElement("TotalValueCalcInd")]
    public string TotalValueCalcInd { get; set; }

    [XmlElement("YearSoldToState")]
    public string YearSoldToState { get; set; }

    [XmlElement("ValueMethod")]
    public string ValueMethod { get; set; }

}