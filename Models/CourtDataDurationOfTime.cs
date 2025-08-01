using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtDataDurationOfTime")]
public class CourtDataDurationOfTime
{
    [XmlElement("LengthAndUnits")]
    public string LengthAndUnits { get; set; }

    [XmlElement("NumberOfDays")]
    public string NumberOfDays { get; set; }

    [XmlElement("NumberOfMonths")]
    public string NumberOfMonths { get; set; }

    [XmlElement("NumberOfYears")]
    public string NumberOfYears { get; set; }

}
}