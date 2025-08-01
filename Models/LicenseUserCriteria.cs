using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LicenseUserCriteria")]
public class LicenseUserCriteria
{
    [XmlElement("LicenseCriteria")]
    public LicenseCriteria LicenseCriteria { get; set; }

}