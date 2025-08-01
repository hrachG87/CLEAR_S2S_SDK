using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategoryEmbezzlement")]
public class CriminalCategoryEmbezzlement
{
    [XmlElement("EmbezzlementBusinessProperty")]
    public CriminalChargetypes EmbezzlementBusinessProperty { get; set; }

    [XmlElement("EmbezzlementInterstateShipment")]
    public CriminalChargetypes EmbezzlementInterstateShipment { get; set; }

    [XmlElement("EmbezzlementBanking")]
    public CriminalChargetypes EmbezzlementBanking { get; set; }

    [XmlElement("EmbezzlementPublicProperty")]
    public CriminalChargetypes EmbezzlementPublicProperty { get; set; }

    [XmlElement("PostalEmbezzlement")]
    public CriminalChargetypes PostalEmbezzlement { get; set; }

    [XmlElement("Embezzlement")]
    public CriminalChargetypes Embezzlement { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}