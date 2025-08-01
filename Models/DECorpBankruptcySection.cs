using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DECorpBankruptcySection")]
public class DECorpBankruptcySection
{
    [XmlElement("BankruptcyInfoRecord")]
    public List<BankruptcyInfoRecord> BankruptcyInfoRecord { get; set; }

}
}