using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FBNVendorStmt")]
public class FBNVendorStmt
{
    [XmlElement("AbandonDate")]
    public string AbandonDate { get; set; }

    [XmlElement("FilingFee")]
    public string FilingFee { get; set; }

    [XmlElement("FilingTerm")]
    public string FilingTerm { get; set; }

    [XmlElement("RecordType")]
    public string RecordType { get; set; }

    [XmlElement("WithdrawnDate")]
    public List<string> WithdrawnDate { get; set; }

}