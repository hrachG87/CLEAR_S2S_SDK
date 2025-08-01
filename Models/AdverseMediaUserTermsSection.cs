using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaUserTermsSection")]
public class AdverseMediaUserTermsSection
{
    [XmlElement("UserTermRecord")]
    public AdverseMediaUserTermRecord UserTermRecord { get; set; }

}
}