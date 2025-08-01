using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("FilingOfficeStmt")]
public class FilingOfficeStmt
{
    [XmlElement("AccountStmt")]
    public string AccountStmt { get; set; }

    [XmlElement("CrossRefFileNumber")]
    public string CrossRefFileNumber { get; set; }

    [XmlElement("CrossReFileNumberFull")]
    public string CrossReFileNumberFull { get; set; }

    [XmlElement("InaccuracyStmt")]
    public string InaccuracyStmt { get; set; }
}
