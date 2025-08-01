using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RealProperty")]
public class RealProperty
{
    [XmlElement("RealPropForeclosureSingle")]
    public RiskFlagInfo RealPropForeclosureSingle { get; set; }

    [XmlElement("RealPropForeclosureMultiple")]
    public RiskFlagInfo RealPropForeclosureMultiple { get; set; }

    [XmlElement("RealPropTransferSingle")]
    public RiskFlagInfo RealPropTransferSingle { get; set; }

    [XmlElement("RealPropTransferMultiple")]
    public RiskFlagInfo RealPropTransferMultiple { get; set; }

    [XmlElement("RealPropAssessorSingle")]
    public RiskFlagInfo RealPropAssessorSingle { get; set; }

    [XmlElement("RealPropAssessorMultiple")]
    public RiskFlagInfo RealPropAssessorMultiple { get; set; }

}