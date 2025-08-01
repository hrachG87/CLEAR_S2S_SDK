using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WorldcheckDocumentUserCriteria")]
public class WorldcheckDocumentUserCriteria
{
    [XmlElement("WorldCheckDocumentCriteria")]
    public WorldCheckDocumentCriteria WorldCheckDocumentCriteria { get; set; }

}
}