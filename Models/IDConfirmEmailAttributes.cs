using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("IDConfirmEmailAttributes")]
public class IDConfirmEmailAttributes
{
    [XmlElement("InvalidEmailFlag")]
    public InvalidEmailFlagAttributes InvalidEmailFlag { get; set; }

    [XmlElement("DisposableEmailFlag")]
    public DisposableEmailFlagAttributes DisposableEmailFlag { get; set; }

    [XmlElement("EmailFraudScoreFlag")]
    public EmailFraudScoreFlagAttributes EmailFraudScoreFlag { get; set; }

    [XmlElement("EmailUserActivityFlag")]
    public EmailUserActivityFlagAttributes EmailUserActivityFlag { get; set; }

    [XmlElement("EmailDeliverabilityFlag")]
    public EmailDeliverabilityFlagAttributes EmailDeliverabilityFlag { get; set; }

    [XmlElement("EmailAttributeDetails")]
    public EmailAttributes EmailAttributeDetails { get; set; }
}
