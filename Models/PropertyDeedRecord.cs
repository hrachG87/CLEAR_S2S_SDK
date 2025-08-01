using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PropertyDeedRecord")]
public class PropertyDeedRecord
{
    [XmlElement("DeedSaleDate")]
    public string DeedSaleDate { get; set; }

    [XmlElement("DeedSaleDateCode")]
    public string DeedSaleDateCode { get; set; }

    [XmlElement("DeedSalesDocNum")]
    public string DeedSalesDocNum { get; set; }

    [XmlElement("DeedState")]
    public string DeedState { get; set; }

    [XmlElement("FourthOwner")]
    public GroupOwnerInfo FourthOwner { get; set; }

    [XmlElement("MailingAddress")]
    public CommonDataAddress MailingAddress { get; set; }

    [XmlElement("OwnershipInfo")]
    public OwnershipInfo OwnershipInfo { get; set; }

    [XmlElement("PrimaryOwner")]
    public GroupOwnerInfo PrimaryOwner { get; set; }

    [XmlElement("PropertyAddress")]
    public CommonDataAddress PropertyAddress { get; set; }

    [XmlElement("PropertyInfo")]
    public PropertyInfo PropertyInfo { get; set; }

    [XmlElement("RecordingInfo")]
    public RecordingInfo RecordingInfo { get; set; }

    [XmlElement("SalesTranscationInfo")]
    public SalesTransactionInfo SalesTranscationInfo { get; set; }

    [XmlElement("SecondaryOwner")]
    public GroupOwnerInfo SecondaryOwner { get; set; }

    [XmlElement("ThirdOwner")]
    public GroupOwnerInfo ThirdOwner { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
