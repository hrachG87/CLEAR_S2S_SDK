using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RealTimeIncarcerationRecord")]
public class RealTimeIncarcerationRecord
{
    [XmlElement("RealTimeIncarcerationRecordSummary")]
    public CourtDominantValues RealTimeIncarcerationRecordSummary { get; set; }

    [XmlElement("RealTimeIncarcerationRecordDetails")]
    public List<RealTimeArrestRecord> RealTimeIncarcerationRecordDetails { get; set; }

}