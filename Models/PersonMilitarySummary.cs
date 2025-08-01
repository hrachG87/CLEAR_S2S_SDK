using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonMilitarySummary")]
public class PersonMilitarySummary
{
    [XmlElement("MilitaryBranchName")]
    public string MilitaryBranchName { get; set; }

    [XmlElement("MilitaryStatus")]
    public string MilitaryStatus { get; set; }
}
