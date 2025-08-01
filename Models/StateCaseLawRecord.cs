using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("StateCaseLawRecord")]
public class StateCaseLawRecord
{
    [XmlElement("StateCaseLawInfo")]
    public List<CaseLawInfo> StateCaseLawInfo { get; set; }

}
}