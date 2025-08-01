using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("UCCFilingHistory")]
public class UCCFilingHistory
{
    [XmlElement("uccfilingInfo")]
    public UCCFilingInfo uccfilingInfo { get; set; }

}