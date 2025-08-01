using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FacilitateCrime")]
public class FacilitateCrime
{
    [XmlElement("FacilitateCrimeFLag")]
    public RiskFlagInfo FacilitateCrimeFLag { get; set; }

}
}