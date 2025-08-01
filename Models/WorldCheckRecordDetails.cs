using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WorldCheckRecordDetails")]
public class WorldCheckRecordDetails
{
    [XmlElement("worldCheckDocumentResponseDetail")]
    public WorldCheckDocumentResponseDetail worldCheckDocumentResponseDetail { get; set; }

}
}