using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIPersonSearchSectionDetails")]
public class RIPersonSearchSectionDetails
{
    [XmlElement("AddressFlags")]
    public PersonAddressFlags AddressFlags { get; set; }

    [XmlElement("SyntheticIdentity")]
    public SyntheticIdentity SyntheticIdentity { get; set; }

    [XmlElement("SingleRiskIndicators")]
    public SingleRiskIndicators SingleRiskIndicators { get; set; }

    [XmlElement("CriminalFlags")]
    public CriminalFlagsV3 CriminalFlags { get; set; }

    [XmlElement("OtherFlags")]
    public OtherFlags OtherFlags { get; set; }

    [XmlElement("News")]
    public RIPersonSearchNews News { get; set; }

    [XmlElement("WebAnalytics")]
    public RIPersonSearchWebAnalytics WebAnalytics { get; set; }

    [XmlElement("RealTimeIncarcerationRecords")]
    public RealTimeIncarcerationRecords RealTimeIncarcerationRecords { get; set; }

}