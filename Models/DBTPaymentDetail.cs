using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DBTPaymentDetail")]
public class DBTPaymentDetail
{
    [XmlElement("DBT")]
    public int DBT { get; set; }

    [XmlElement("Balance")]
    public int Balance { get; set; }

    [XmlElement("BalanceTrend")]
    public string BalanceTrend { get; set; }

    [XmlElement("CurrentDBTPercentage")]
    public int CurrentDBTPercentage { get; set; }

    [XmlElement("DBT30Percentage")]
    public int DBT30Percentage { get; set; }

    [XmlElement("DBT60Percentage")]
    public int DBT60Percentage { get; set; }

    [XmlElement("DBT90Percentage")]
    public int DBT90Percentage { get; set; }

    [XmlElement("DBTOver90Percentage")]
    public int DBTOver90Percentage { get; set; }

}