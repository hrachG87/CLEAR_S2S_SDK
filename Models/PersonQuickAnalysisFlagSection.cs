using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonQuickAnalysisFlagSection")]
public class PersonQuickAnalysisFlagSection
{
    [XmlElement("QuickAnalysisFlagRecord")]
    public List<PersonQuickAnalysisFlagRecord> QuickAnalysisFlagRecord { get; set; }

}
}