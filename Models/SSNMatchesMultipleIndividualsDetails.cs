using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SSNMatchesMultipleIndividualsDetails")]
public class SSNMatchesMultipleIndividualsDetails
{
    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("Source")]
    public List<string> Source { get; set; }

    [XmlElement("PersonName")]
    public List<string> PersonName { get; set; }

    [XmlElement("DocumentIdentifierInfo")]
    public List<EidvPersonSearchDocumentIdentifierInfo> DocumentIdentifierInfo { get; set; }

}
}