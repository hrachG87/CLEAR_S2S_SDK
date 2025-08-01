using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FlagsSearchAssociationType")]
public class FlagsSearchAssociationType
{
    [XmlElement("TypeOfAssociation")]
    public List<string> TypeOfAssociation { get; set; }

}
}