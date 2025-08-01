using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RawAdditionalInfoList")]
public class RawAdditionalInfoList
{
    [XmlElement("RawAdditionalInfo")]
    public List<RawAdditionalInfo> RawAdditionalInfo { get; set; }

}