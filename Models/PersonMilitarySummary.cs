using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonMilitarySummary")]
public class PersonMilitarySummary
{
    [XmlElement("MilitaryBranchName")]
    public string MilitaryBranchName { get; set; }

    [XmlElement("MilitaryStatus")]
    public string MilitaryStatus { get; set; }

}
}