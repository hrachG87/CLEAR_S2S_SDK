using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonQuickAnalysisFlagResponseDetailContainer")]
public class PersonQuickAnalysisFlagResponseDetailContainer
{
    [XmlElement("PersonQuickAnalysisFlagResponseDetail")]
    public PersonQuickAnalysisFlagResponseDetail PersonQuickAnalysisFlagResponseDetail { get; set; }

}
}