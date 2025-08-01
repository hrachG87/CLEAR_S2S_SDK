using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessPhoneRecord")]
public class BusinessPhoneRecord
{
    [XmlElement("AdSize")]
    public string AdSize { get; set; }

    [XmlElement("BusinessInfo")]
    public BusinessDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("PersonInfo")]
    public BusinessPersonInfo PersonInfo { get; set; }

    [XmlElement("EmployeeSizeDesc")]
    public string EmployeeSizeDesc { get; set; }

    [XmlElement("FranchiseDesc")]
    public List<string> FranchiseDesc { get; set; }

    [XmlElement("IndustryDesc")]
    public string IndustryDesc { get; set; }

    [XmlElement("PersonOrBusinessIndicator")]
    public string PersonOrBusinessIndicator { get; set; }

    [XmlElement("PopulationSize")]
    public string PopulationSize { get; set; }

    [XmlElement("PublicHeldInd")]
    public string PublicHeldInd { get; set; }

    [XmlElement("SalesVolumeDesc")]
    public string SalesVolumeDesc { get; set; }

    [XmlElement("SelectedSIC")]
    public string SelectedSIC { get; set; }

    [XmlElement("SelectedSICDesc")]
    public string SelectedSICDesc { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}
}