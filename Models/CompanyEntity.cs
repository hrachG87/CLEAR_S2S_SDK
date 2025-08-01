using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyEntity")]
public class CompanyEntity
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
    public Summary Summary { get; set; }

    [XmlElement("SearchRecords")]
    public SearchRecords SearchRecords { get; set; }

    [XmlElement("AdditionalPhoneNumbers")]
    public EidvBusinessSearchAdditionalPhoneNumbers AdditionalPhoneNumbers { get; set; }

    [XmlElement("OfacListing")]
    public EidvBusinessOfacListing OfacListing { get; set; }

    [XmlElement("BusinessUsedAsResidentialAddress")]
    public BusinessAddressUsedAsResidentialAddress BusinessUsedAsResidentialAddress { get; set; }

    [XmlElement("PoBoxListedAsAddress")]
    public PoBoxListedAsAddress PoBoxListedAsAddress { get; set; }

    [XmlElement("OtherListingsLinkedToBusinessPhoneNumber")]
    public OtherListingsLinkedToBusinessPhoneNumber OtherListingsLinkedToBusinessPhoneNumber { get; set; }

    [XmlElement("OtherBusinessesLinkedToTheBusinessAddress")]
    public OtherBusinessesLinkedToTheBusinessAddress OtherBusinessesLinkedToTheBusinessAddress { get; set; }

    [XmlElement("OtherBusineesesLinkedToTheSameFein")]
    public OtherBusinessesLinkedToTheSameFein OtherBusineesesLinkedToTheSameFein { get; set; }

    [XmlElement("BusinessSingleSourceTiedToEntity")]
    public BusinessSingleSourceTiedToEntity BusinessSingleSourceTiedToEntity { get; set; }

    [XmlElement("GroupId")]
    public string GroupId { get; set; }
}
