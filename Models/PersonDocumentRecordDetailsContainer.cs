using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonDocumentRecordDetailsContainer")]
public class PersonDocumentRecordDetailsContainer
{
    [XmlElement("PersonDocumentResponseDetail")]
    public PersonDocumentResponseDetail PersonDocumentResponseDetail { get; set; }

}
}