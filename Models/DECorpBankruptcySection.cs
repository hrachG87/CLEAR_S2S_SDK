using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DECorpBankruptcySection")]
public class DECorpBankruptcySection
{
    [XmlElement("BankruptcyInfoRecord")]
    public List<BankruptcyInfoRecord> BankruptcyInfoRecord { get; set; }

}