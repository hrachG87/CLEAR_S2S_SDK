using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RealPropertyDatasources")]
public class RealPropertyDatasources
{
    [XmlElement("PublicRecordRealProperty")]
    public string PublicRecordRealProperty { get; set; }
}
