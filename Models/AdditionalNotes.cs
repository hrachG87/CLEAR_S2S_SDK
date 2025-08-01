using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdditionalNotes")]
public class AdditionalNotes
{
    [XmlElement("DataLabel")]
    public string DataLabel { get; set; }

    [XmlElement("DataValue")]
    public string DataValue { get; set; }

}
}