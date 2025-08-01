using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("FictitiousBusinessRecord")]
public class FictitiousBusinessRecord
{
    [XmlElement("BusinessInfo")]
    public BusinessDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("CarrierRoute")]
    public string CarrierRoute { get; set; }

    [XmlElement("BusinessContact")]
    public List<BusinessPersonInfo> BusinessContact { get; set; }

    [XmlElement("FilingInfo")]
    public BusinessDataFilingInfo FilingInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("FBNBusinessOwner")]
    public List<BusinessPersonInfo> FBNBusinessOwner { get; set; }

    [XmlElement("FBNVendorStmt")]
    public List<FBNVendorStmt> FBNVendorStmt { get; set; }
}
