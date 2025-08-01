using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategoryFlightEscape")]
public class CriminalCategoryFlightEscape
{
    [XmlElement("Escape")]
    public CriminalChargetypes Escape { get; set; }

    [XmlElement("FlightToAvoid")]
    public CriminalChargetypes FlightToAvoid { get; set; }

    [XmlElement("AidPrisonerEscape")]
    public CriminalChargetypes AidPrisonerEscape { get; set; }

    [XmlElement("HarborFugitive")]
    public CriminalChargetypes HarborFugitive { get; set; }

    [XmlElement("FlightEscape")]
    public CriminalChargetypes FlightEscape { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}