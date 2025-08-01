using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessProfileRecord")]
public class BusinessProfileRecord
{
    [XmlElement("BusinessInfo")]
    public BusinessProInfo BusinessInfo { get; set; }

    [XmlElement("AdditionalBusinessInfo")]
    public AdditionalBusinessInfo AdditionalBusinessInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("SICAndNAICS")]
    public SICAndNAICS SICAndNAICS { get; set; }

}
}