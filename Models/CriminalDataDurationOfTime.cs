using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalDataDurationOfTime")]
public class CriminalDataDurationOfTime
{
    [XmlElement("LengthAndUnits")]
    public string LengthAndUnits { get; set; }

    [XmlElement("NumberOfHours")]
    public string NumberOfHours { get; set; }

    [XmlElement("NumberOfDays")]
    public string NumberOfDays { get; set; }

    [XmlElement("NumberOfMonths")]
    public string NumberOfMonths { get; set; }

    [XmlElement("NumberOfYears")]
    public string NumberOfYears { get; set; }

}
}