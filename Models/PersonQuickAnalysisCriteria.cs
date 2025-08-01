using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonQuickAnalysisCriteria")]
public class PersonQuickAnalysisCriteria
{
    [XmlElement("PersonQuickAnalysisFlagCriteria")]
    public PersonQuickAnalysisFlagCriteria PersonQuickAnalysisFlagCriteria { get; set; }

}
}