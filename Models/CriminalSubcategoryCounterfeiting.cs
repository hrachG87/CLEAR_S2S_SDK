using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalSubcategoryCounterfeiting")]
public class CriminalSubcategoryCounterfeiting
{
    [XmlElement("Counterfeiting")]
    public CriminalChargetypes Counterfeiting { get; set; }

    [XmlElement("PassingCounterfeit")]
    public CriminalChargetypes PassingCounterfeit { get; set; }

    [XmlElement("PossessionCounterfeit")]
    public CriminalChargetypes PossessionCounterfeit { get; set; }

    [XmlElement("TransportCounterfeit")]
    public CriminalChargetypes TransportCounterfeit { get; set; }

    [XmlElement("CounterfeitCellphone")]
    public CriminalChargetypes CounterfeitCellphone { get; set; }

    [XmlElement("CounterfeitTrademarkItems")]
    public CriminalChargetypes CounterfeitTrademarkItems { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
