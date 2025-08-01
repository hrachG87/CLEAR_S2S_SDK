using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessDocumentResponseDetails")]
public class BusinessDocumentResponseDetails
{
    [XmlElement("BusinessDocumentResponseDetail")]
    public BusinessDocumentResponseDetail BusinessDocumentResponseDetail { get; set; }

}
}