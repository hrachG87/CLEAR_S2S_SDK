using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("QuarterlyPaymentDetail")]
public class QuarterlyPaymentDetail
{
    [XmlElement("Year")]
    public int Year { get; set; }

    [XmlElement("Quarter")]
    public int Quarter { get; set; }

    [XmlElement("DBTPaymentDetail")]
    public DBTPaymentDetail DBTPaymentDetail { get; set; }
}
