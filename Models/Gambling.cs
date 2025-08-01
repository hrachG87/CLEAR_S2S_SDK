using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Gambling")]
public class Gambling
{
    [XmlElement("Bookmaking")]
    public RiskFlagInfo Bookmaking { get; set; }

    [XmlElement("OperateCardGame")]
    public RiskFlagInfo OperateCardGame { get; set; }

    [XmlElement("CardGame")]
    public RiskFlagInfo CardGame { get; set; }

    [XmlElement("OperateDiceGame")]
    public RiskFlagInfo OperateDiceGame { get; set; }

    [XmlElement("DiceGame")]
    public RiskFlagInfo DiceGame { get; set; }

    [XmlElement("PossessGamblingDevice")]
    public RiskFlagInfo PossessGamblingDevice { get; set; }

    [XmlElement("TransportGamblingDevice")]
    public RiskFlagInfo TransportGamblingDevice { get; set; }

    [XmlElement("UnregGamblingDevice")]
    public RiskFlagInfo UnregGamblingDevice { get; set; }

    [XmlElement("GamblingDevice")]
    public RiskFlagInfo GamblingDevice { get; set; }

    [XmlElement("PossessGamblingGoods")]
    public RiskFlagInfo PossessGamblingGoods { get; set; }

    [XmlElement("TransportGamblingGoods")]
    public RiskFlagInfo TransportGamblingGoods { get; set; }

    [XmlElement("GamblingGoods")]
    public RiskFlagInfo GamblingGoods { get; set; }

    [XmlElement("OperateLottery")]
    public RiskFlagInfo OperateLottery { get; set; }

    [XmlElement("LotteryRunner")]
    public RiskFlagInfo LotteryRunner { get; set; }

    [XmlElement("Lottery")]
    public RiskFlagInfo Lottery { get; set; }

    [XmlElement("SportsTamper")]
    public RiskFlagInfo SportsTamper { get; set; }

    [XmlElement("TransmitWager")]
    public RiskFlagInfo TransmitWager { get; set; }

    [XmlElement("EstabGamblingPlace")]
    public RiskFlagInfo EstabGamblingPlace { get; set; }

    [XmlElement("GamblingFlag")]
    public RiskFlagInfo GamblingFlag { get; set; }

    [XmlElement("PlayingDiceGame")]
    public RiskFlagInfo PlayingDiceGame { get; set; }

}