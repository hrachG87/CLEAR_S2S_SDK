using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Abortion")]
public class Abortion
{
    [XmlElement("AbortionOnOther")]
    public RiskFlagInfo AbortionOnOther { get; set; }

    [XmlElement("Abortion On Self")]
    public RiskFlagInfo AbortionOnSelf { get; set; }

    [XmlElement("SubmissionToAbortion")]
    public RiskFlagInfo SubmissionToAbortion { get; set; }

    [XmlElement("Abortifacient")]
    public RiskFlagInfo Abortifacient { get; set; }

    [XmlElement("AbortionFlag")]
    public RiskFlagInfo AbortionFlag { get; set; }

}
}