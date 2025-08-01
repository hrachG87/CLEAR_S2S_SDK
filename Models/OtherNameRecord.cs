using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("OtherNameRecord")]
public class OtherNameRecord
{
    [XmlElement("PersonInfo")]
    public PersonReportPersonInfo PersonInfo { get; set; }

}