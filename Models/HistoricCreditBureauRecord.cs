using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("HistoricCreditBureauRecord")]
public class HistoricCreditBureauRecord
{
    [XmlElement("Names")]
    public NameInfo Names { get; set; }

    [XmlElement("DateOfBirth")]
    public List<string> DateOfBirth { get; set; }

    [XmlElement("DateOfDeath")]
    public string DateOfDeath { get; set; }

    [XmlElement("Notes")]
    public string Notes { get; set; }

    [XmlElement("PhoneNumber")]
    public List<string> PhoneNumber { get; set; }

    [XmlElement("FiledSinceDate")]
    public List<string> FiledSinceDate { get; set; }

    [XmlElement("Addresses")]
    public List<CommonDataAddress> Addresses { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("SSNInfo")]
    public SSNInfo SSNInfo { get; set; }

}
}