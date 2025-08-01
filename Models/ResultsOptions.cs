using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ResultsOptions")]
public class ResultsOptions
{
    [XmlElement("SortOptions")]
    public SortOptions SortOptions { get; set; }

    [XmlElement("ResultsFilter")]
    public ResultsFilter ResultsFilter { get; set; }

}
}