using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("IncomeInfo")]
public class IncomeInfo
{
    [XmlElement("TypeOfIncome")]
    public string TypeOfIncome { get; set; }

    [XmlElement("IncomeGross")]
    public string IncomeGross { get; set; }

    [XmlElement("IncomeNet")]
    public string IncomeNet { get; set; }

}