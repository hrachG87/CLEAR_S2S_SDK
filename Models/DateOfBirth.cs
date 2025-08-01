using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DateOfBirth")]
public class DateOfBirth
{
    [XmlElement("FullDateOfBirth")]
    public string FullDateOfBirth { get; set; }

    [XmlElement("YearOfBirth")]
    public string YearOfBirth { get; set; }

    [XmlElement("MonthOfBirth")]
    public string MonthOfBirth { get; set; }

    [XmlElement("DayOfBirth")]
    public string DayOfBirth { get; set; }
}
