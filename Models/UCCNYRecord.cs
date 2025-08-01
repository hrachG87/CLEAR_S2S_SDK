using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("UCCNYRecord")]
public class UCCNYRecord
{
    [XmlElement("BusinessInfo")]
    public BusinessDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("CityRegisterFileNumber")]
    public string CityRegisterFileNumber { get; set; }

    [XmlElement("Comments")]
    public Comments Comments { get; set; }

    [XmlElement("CrossReference")]
    public List<CrossReference> CrossReference { get; set; }

    [XmlElement("Debtor")]
    public List<BusinessPartyInfo> Debtor { get; set; }

    [XmlElement("DocumentAmount")]
    public string DocumentAmount { get; set; }

    [XmlElement("DocumentID")]
    public string DocumentID { get; set; }

    [XmlElement("FedTaxAssessDate")]
    public string FedTaxAssessDate { get; set; }

    [XmlElement("FedTaxSerialNumber")]
    public string FedTaxSerialNumber { get; set; }

    [XmlElement("OtherParty")]
    public List<BusinessPartyInfo> OtherParty { get; set; }

    [XmlElement("ParcelInfo")]
    public ParcelInfo ParcelInfo { get; set; }

    [XmlElement("RealPropTaxTransferNumber")]
    public string RealPropTaxTransferNumber { get; set; }

    [XmlElement("RecordBorough")]
    public string RecordBorough { get; set; }

    [XmlElement("ReelNumber")]
    public string ReelNumber { get; set; }

    [XmlElement("ReelPage")]
    public string ReelPage { get; set; }

    [XmlElement("ReelYear")]
    public string ReelYear { get; set; }

    [XmlElement("SecuredParty")]
    public List<BusinessPartyInfo> SecuredParty { get; set; }

    [XmlElement("TypeOfCollateral")]
    public string TypeOfCollateral { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}