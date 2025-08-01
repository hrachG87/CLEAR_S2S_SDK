using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CounterfeitingForgery")]
public class CounterfeitingForgery
{
    [XmlElement("Counterfeiting")]
    public RiskFlagInfo Counterfeiting { get; set; }

    [XmlElement("PassingCounterfeit")]
    public RiskFlagInfo PassingCounterfeit { get; set; }

    [XmlElement("PossessionCounterfeit")]
    public RiskFlagInfo PossessionCounterfeit { get; set; }

    [XmlElement("TransportCounterfeit")]
    public RiskFlagInfo TransportCounterfeit { get; set; }

    [XmlElement("ForgeryOfChecks")]
    public RiskFlagInfo ForgeryOfChecks { get; set; }

    [XmlElement("Forgery")]
    public RiskFlagInfo Forgery { get; set; }

    [XmlElement("PassingForgedDocs")]
    public RiskFlagInfo PassingForgedDocs { get; set; }

    [XmlElement("PossessionForged")]
    public RiskFlagInfo PossessionForged { get; set; }

    [XmlElement("TransportForged")]
    public RiskFlagInfo TransportForged { get; set; }

    [XmlElement("PossessionToolsCounterfeitForgery")]
    public RiskFlagInfo PossessionToolsCounterfeitForgery { get; set; }

    [XmlElement("TransportToolsCounterfeitForgery")]
    public RiskFlagInfo TransportToolsCounterfeitForgery { get; set; }

    [XmlElement("FalseIdDocuments")]
    public RiskFlagInfo FalseIdDocuments { get; set; }

    [XmlElement("CounterfeitCellphone")]
    public RiskFlagInfo CounterfeitCellphone { get; set; }

    [XmlElement("CounterfeitTrademarkItems")]
    public RiskFlagInfo CounterfeitTrademarkItems { get; set; }

    [XmlElement("ProvidingCounterfeitForgery")]
    public RiskFlagInfo ProvidingCounterfeitForgery { get; set; }

}