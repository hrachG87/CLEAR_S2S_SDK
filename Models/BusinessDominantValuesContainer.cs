using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessDominantValuesContainer")]
public class BusinessDominantValuesContainer
{
    [XmlElement("BusinessDominantValues")]
    public BusinessDominantValues BusinessDominantValues { get; set; }

}
}