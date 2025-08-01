using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BankruptcyInfoRecord")]
public class BankruptcyInfoRecord
{
    [XmlElement("BankruptcyCaseNum")]
    public string BankruptcyCaseNum { get; set; }

    [XmlElement("BankruptcyDate")]
    public string BankruptcyDate { get; set; }

    [XmlElement("BankruptcyStatus")]
    public string BankruptcyStatus { get; set; }

}