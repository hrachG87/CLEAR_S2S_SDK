using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonReportAssociateAnalyticsChartRecord")]
public class PersonReportAssociateAnalyticsChartRecord
{
    [XmlElement("Associates")]
    public List<PersonReportChartDetails> Associates { get; set; }

    [XmlElement("Relatives")]
    public List<PersonReportChartDetails> Relatives { get; set; }

    [XmlElement("AssociatesWithEntityId")]
    public List<PersonReportChartDetailsWithEntityId> AssociatesWithEntityId { get; set; }

    [XmlElement("RelativeWithEntityId")]
    public List<PersonReportChartDetailsWithEntityId> RelativeWithEntityId { get; set; }
}
