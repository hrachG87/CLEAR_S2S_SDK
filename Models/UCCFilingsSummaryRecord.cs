using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UCCFilingsSummaryRecord")]
public class UCCFilingsSummaryRecord
{
    [XmlElement("UCCFilingsSummary")]
    public UCCFilingsSummary UCCFilingsSummary { get; set; }

    [XmlElement("UCCDetails")]
    public UCCDetails UCCDetails { get; set; }

}
}