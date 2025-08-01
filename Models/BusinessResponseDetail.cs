using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessResponseDetail")]
public class BusinessResponseDetail
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("AlternateBusinessNames")]
    public ListInfo AlternateBusinessNames { get; set; }

    [XmlElement("AlternateAddresses")]
    public List<CommonDataAddress> AlternateAddresses { get; set; }

    [XmlElement("Phones")]
    public ListInfo Phones { get; set; }

    [XmlElement("BusinessExecutives")]
    public List<BusinessExecutives> BusinessExecutives { get; set; }

    [XmlElement("BusinessContacts")]
    public List<BusinessContacts> BusinessContacts { get; set; }

    [XmlElement("ListOfFEINs")]
    public ListInfo ListOfFEINs { get; set; }

    [XmlElement("ListOfDUNSNumbers")]
    public ListInfo ListOfDUNSNumbers { get; set; }

    [XmlElement("ListOfFileStates")]
    public ListInfo ListOfFileStates { get; set; }

    [XmlElement("CorporationInfo")]
    public List<CorporationInfo> CorporationInfo { get; set; }

    [XmlElement("ListOfNPINumbers")]
    public ListInfo ListOfNPINumbers { get; set; }

    [XmlElement("LegalUltimateParent")]
    public string LegalUltimateParent { get; set; }

    [XmlElement("LegalImmediateParent")]
    public string LegalImmediateParent { get; set; }

    [XmlElement("LocationType")]
    public string LocationType { get; set; }

    [XmlElement("Message")]
    public string Message { get; set; }

    [XmlElement("CompanyEntityId")]
    public string CompanyEntityId { get; set; }

    [XmlElement("AllSourceDocuments")]
    public List<Sources> AllSourceDocuments { get; set; }

    [XmlElement("naicsdetail")]
    public List<NAICSDetail> naicsdetail { get; set; }

    [XmlElement("sicdetail")]
    public List<SICDetail> sicdetail { get; set; }

    [XmlElement("UCCInfo")]
    public List<UCCInfo> UCCInfo { get; set; }

}