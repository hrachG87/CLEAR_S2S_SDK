using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EIDVPersonEntity")]
public class EIDVPersonEntity
{
    [XmlElement("RecordNumber")]
    public string RecordNumber { get; set; }

    [XmlElement("TotalScore")]
    public string TotalScore { get; set; }

    [XmlElement("MinThresholdScore")]
    public string MinThresholdScore { get; set; }

    [XmlElement("IdentityVerified")]
    public bool IdentityVerified { get; set; }

    [XmlElement("EntityIdentifier")]
    public string EntityIdentifier { get; set; }

    [XmlElement("Summary")]
    public EidvSummary Summary { get; set; }

    [XmlElement("SearchRecords")]
    public EidvSearchRecords SearchRecords { get; set; }

    [XmlElement("KnownAddresses")]
    public KnownAddresses KnownAddresses { get; set; }

    [XmlElement("AdditionalPhoneNumbers")]
    public EidvPersonSearchAdditionalPhoneNumbers AdditionalPhoneNumbers { get; set; }

    [XmlElement("KnownEmailAddresses")]
    public KnownEmailAddresses KnownEmailAddresses { get; set; }

    [XmlElement("Death")]
    public Death Death { get; set; }

    [XmlElement("OfacListing")]
    public EidvOfacListing OfacListing { get; set; }

    [XmlElement("MultipleSSNs")]
    public MultipleSSNs MultipleSSNs { get; set; }

    [XmlElement("SsnDoesNotExist")]
    public SsnDoesNotExist SsnDoesNotExist { get; set; }

    [XmlElement("SingleSourceTiedToEntity")]
    public SingleSourceTiedToEntity SingleSourceTiedToEntity { get; set; }

    [XmlElement("HistoricalAddress")]
    public HistoricalAddress HistoricalAddress { get; set; }

    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("SSNMatchesMultipleIndividuals")]
    public SSNMatchesMultipleIndividuals SSNMatchesMultipleIndividuals { get; set; }

}
}