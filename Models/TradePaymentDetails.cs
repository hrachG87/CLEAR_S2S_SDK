using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("TradePaymentDetails")]
public class TradePaymentDetails
{
    [XmlElement("LinesReported")]
    public int LinesReported { get; set; }

    [XmlElement("RecentHighCredit")]
    public int RecentHighCredit { get; set; }

    [XmlElement("RecentHighCreditTrend")]
    public string RecentHighCreditTrend { get; set; }

    [XmlElement("DBTPaymentDetail")]
    public DBTPaymentDetail DBTPaymentDetail { get; set; }
}
