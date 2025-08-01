using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonQuickAnalysisFlagResponseDetailContainer")]
public class PersonQuickAnalysisFlagResponseDetailContainer
{
    [XmlElement("PersonQuickAnalysisFlagResponseDetail")]
    public PersonQuickAnalysisFlagResponseDetail PersonQuickAnalysisFlagResponseDetail { get; set; }

}