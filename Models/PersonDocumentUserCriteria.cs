using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonDocumentUserCriteria")]
public class PersonDocumentUserCriteria
{
    [XmlElement("PersonDocumentCriteria")]
    public PersonDocumentCriteria PersonDocumentCriteria { get; set; }

}
}