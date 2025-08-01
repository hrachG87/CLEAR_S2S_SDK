using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryGambling")]
public class CriminalCategoryGambling
{
    [XmlElement("Bookmaking")]
    public CriminalChargetypes Bookmaking { get; set; }

    [XmlElement("OperateCardGame")]
    public CriminalChargetypes OperateCardGame { get; set; }

    [XmlElement("CardGame")]
    public CriminalChargetypes CardGame { get; set; }

    [XmlElement("OperateDiceGame")]
    public CriminalChargetypes OperateDiceGame { get; set; }

    [XmlElement("PlayingDiceGame")]
    public CriminalChargetypes PlayingDiceGame { get; set; }

    [XmlElement("DiceGame")]
    public CriminalChargetypes DiceGame { get; set; }

    [XmlElement("PossessGamblingDevice")]
    public CriminalChargetypes PossessGamblingDevice { get; set; }

    [XmlElement("TransportGamblingDevice")]
    public CriminalChargetypes TransportGamblingDevice { get; set; }

    [XmlElement("UnregGamblingDevice")]
    public CriminalChargetypes UnregGamblingDevice { get; set; }

    [XmlElement("GamblingDevice")]
    public CriminalChargetypes GamblingDevice { get; set; }

    [XmlElement("PossessGamblingGoods")]
    public CriminalChargetypes PossessGamblingGoods { get; set; }

    [XmlElement("TransportGamblingGoods")]
    public CriminalChargetypes TransportGamblingGoods { get; set; }

    [XmlElement("GamblingGoods")]
    public CriminalChargetypes GamblingGoods { get; set; }

    [XmlElement("OperateLottery")]
    public CriminalChargetypes OperateLottery { get; set; }

    [XmlElement("LotteryRunner")]
    public CriminalChargetypes LotteryRunner { get; set; }

    [XmlElement("Lottery")]
    public CriminalChargetypes Lottery { get; set; }

    [XmlElement("SportsTamper")]
    public CriminalChargetypes SportsTamper { get; set; }

    [XmlElement("TransmitWager")]
    public CriminalChargetypes TransmitWager { get; set; }

    [XmlElement("EstabGamblingPlace")]
    public CriminalChargetypes EstabGamblingPlace { get; set; }

    [XmlElement("Gambling")]
    public CriminalChargetypes Gambling { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
