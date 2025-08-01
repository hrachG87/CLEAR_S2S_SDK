using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessFactsRecord")]
public class BusinessFactsRecord
{
    [XmlElement("Description")]
    public string Description { get; set; }

    [XmlElement("YearsOnFile")]
    public string YearsOnFile { get; set; }

    [XmlElement("YearsInBusiness")]
    public int YearsInBusiness { get; set; }

    [XmlElement("StateOfIncorporation")]
    public string StateOfIncorporation { get; set; }

    [XmlElement("DateOfIncorporation")]
    public string DateOfIncorporation { get; set; }

    [XmlElement("BusinessType")]
    public string BusinessType { get; set; }

    [XmlElement("Contacts")]
    public Contacts Contacts { get; set; }

    [XmlElement("NumberOfEmployees")]
    public int NumberOfEmployees { get; set; }

    [XmlElement("Sales")]
    public int Sales { get; set; }

    [XmlElement("NonProfit")]
    public bool NonProfit { get; set; }

    [XmlElement("PublicCompany")]
    public bool PublicCompany { get; set; }

    [XmlElement("StockExchange")]
    public string StockExchange { get; set; }

    [XmlElement("StockSymbol")]
    public string StockSymbol { get; set; }

    [XmlElement("Fortune1000Rankings")]
    public Fortune1000Rankings Fortune1000Rankings { get; set; }

    [XmlElement("SICInfos")]
    public SICInfos SICInfos { get; set; }

    [XmlElement("NAICSInfos")]
    public NAICSInfos NAICSInfos { get; set; }
}
